using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Player
    {
        #region Fields
        private double _money;
        private List<Flower> _flowersInStock;
        private List<Cat> _catsInStock;
        private string _name;
        private List<ISkill> _skills;
        #endregion
        #region Properties
        public double Money => _money;
        public List<Flower> FlowersInStock => _flowersInStock;
        public List<Cat> CatsInStock => _catsInStock;
        public string Name => _name;
        public List<ISkill> Skills => _skills;
        #endregion
        public Player(string name)
        {
            _money = 0;
            _name = name;
            _flowersInStock = new List<Flower>();
            _catsInStock = new List<Cat>();
            _skills = new List<ISkill>() {new FlowersPicking(CatQualificationNames.Beginner,1) };
        }
        public Dictionary<FlowerRarityNaming, int> InfoFlower()
        {
            Dictionary<FlowerRarityNaming, int> infoFlowers = new Dictionary<FlowerRarityNaming, int>();
            infoFlowers.Add(FlowerRarityNaming.Common, (from s in _flowersInStock where s.Rarity.RarityName == FlowerRarityNaming.Common select s).ToList().Count);
            infoFlowers.Add(FlowerRarityNaming.Rare, (from s in _flowersInStock where s.Rarity.RarityName == FlowerRarityNaming.Rare select s).ToList().Count);
            infoFlowers.Add(FlowerRarityNaming.Elite, (from s in _flowersInStock where s.Rarity.RarityName == FlowerRarityNaming.Elite select s).ToList().Count);
            return infoFlowers;
        }
    }
}

