using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows;

namespace WpfApp1
{
    public class Player : INotifyPropertyChanged
    {
        #region Fields
        private double _money;
        private ObservableCollection<Flower> _flowersInStock;
        private ObservableCollection<Cat> _catsInStock;
        private string _name;
        private List<ISkill> _skills;
        private ObservableCollection<Flower> _Common;
        private ObservableCollection<Flower> _Rare;
        private ObservableCollection<Flower> _Elite;

        public event PropertyChangedEventHandler PropertyChanged;
        public void Notify(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion


        #region Properties

        public double Money
        { get { return _money; }
          set{  _money = value;
                Notify("Money"); } }
        public ObservableCollection<Flower> FlowersInStock
        {
            get => _flowersInStock;
            set
            {
                _flowersInStock = value;
                Notify("FlowerUpd");
            }
        }
        public ObservableCollection<Cat> CatsInStock
        {
            get => _catsInStock;
            set { _catsInStock = value; }
        }
        public string Name => _name;
        public List<ISkill> Skills => _skills;
        public ObservableCollection<Flower> CommonFlower
        {
            get { return _Common; }
            set { _Common = value;
                Notify("FlowerCom");
            }
        
        }
        public ObservableCollection<Flower> Rare
        {
            get { return _Rare; }
            set
            {
                _Rare = value;
                Notify("FlowerRare");
            }

        }
        public ObservableCollection<Flower> Elite
        {
            get { return _Elite; }
            set
            {
                _Elite = value;
                Notify("FlowerRare");
            }

        }
        #endregion

        #region Methods

        public Dictionary<FlowerRarityNaming, int> InfoFlower()
        {
            Dictionary<FlowerRarityNaming, int> infoFlowers = new Dictionary<FlowerRarityNaming, int>();
            infoFlowers.Add(FlowerRarityNaming.Common, (from s in _flowersInStock where s.Rarity.RarityName == FlowerRarityNaming.Common select s).ToList().Count);
            infoFlowers.Add(FlowerRarityNaming.Rare, (from s in _flowersInStock where s.Rarity.RarityName == FlowerRarityNaming.Rare select s).ToList().Count);
            infoFlowers.Add(FlowerRarityNaming.Elite, (from s in _flowersInStock where s.Rarity.RarityName == FlowerRarityNaming.Elite select s).ToList().Count);
            return infoFlowers;
        }
        
        
        public void PickFlower()
        {
            Flower flower = Storage.PickFlower(Skills[0]);

            if (flower.Rarity.RarityName == FlowerRarityNaming.Common)
            {CommonFlower.Add(flower);
            }
            if (flower.Rarity.RarityName == FlowerRarityNaming.Rare)
            {
                Rare.Add(flower);
            }
            if (flower.Rarity.RarityName == FlowerRarityNaming.Elite)
            {
                Elite.Add(flower);
            }
            FlowersInStock.Add(flower);
           
        }
        private void Pickering(object sender, ElapsedEventArgs e)
        {
            foreach (var cat in _catsInStock)
            {
                cat.Work(this);
            }
        }
        public void Piker()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 2000;
            timer.Elapsed += Pickering;
            timer.AutoReset = true;
            timer.Start();
        }
        public void AddCAt(Cat cat)
        {
            if (cat == null)
            {
                MessageBox.Show("cat not buyed");
                return;
            }
            if (CatsInStock.ToList().Find(x => x.WorkType == WorkPlaceName.FlowerMeadow) == null)
            {
                _catsInStock.Add(cat);
                Piker();
            }
            else _catsInStock.Add(cat);
        }

        public void CraftWreathEasy()
        {
            if (Storage.CheckRequariments(this, WreathTypeName.Easy))
            {
                Wreath wreath = Storage.Creating(Skills[0], WreathTypeName.Easy);
                Money += wreath.Price;
                int removeInd = 1;
                int count_item = FlowersInStock.Count;
                int reqCommon = Storage.requariments[WreathTypeName.Easy].FlowersRequirements[FlowerRarityNaming.Common];
                for (int i = 0; i < count_item; i++)
                {   
                    if (FlowersInStock[i].Rarity.RarityName == FlowerRarityNaming.Common
                        && removeInd < reqCommon)
                    {
                        FlowersInStock.RemoveAt(i);
                        
                            removeInd++;
                        i = 0;
                    }
                    if (FlowersInStock[i].Rarity.RarityName == FlowerRarityNaming.Common
                        && removeInd == reqCommon)
                    {
                        
                        FlowersInStock.RemoveAt(i);
                        break;
                    }


                }

                for (int i = 0; i < reqCommon; i++)
                {
                    CommonFlower.RemoveAt(0);

                }
            }
            else
            {
                MessageBox.Show($"не хватает {Math.Abs(InfoFlower()[FlowerRarityNaming.Common] - Storage.requariments[WreathTypeName.Easy].FlowersRequirements[FlowerRarityNaming.Common])} обычных цветов");
            }
        }
       



        #endregion
        public Player(string name)
        {
            _money = 0;
            _name = name;
            _flowersInStock = new ObservableCollection<Flower>();
            _catsInStock = new ObservableCollection<Cat>();
            _skills = new List<ISkill>() { new FlowersPicking(CatQualificationNames.Beginner, 1),
            new WreathWeaving(CatQualificationNames.Beginner, 1)};
            _Common = new ObservableCollection<Flower>();
            Rare = new ObservableCollection<Flower>();
            Elite = new ObservableCollection<Flower>();
        }
        public Player()
        {
            _money = 0;
            _name = "default";
            _flowersInStock = new ObservableCollection<Flower>();
            _catsInStock = new ObservableCollection<Cat>();
            _skills = new List<ISkill>() { new FlowersPicking(CatQualificationNames.Beginner, 1),
            new WreathWeaving(CatQualificationNames.Beginner, 1) };
        }
    }
}

