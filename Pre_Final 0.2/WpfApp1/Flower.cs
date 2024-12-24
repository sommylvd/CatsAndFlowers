using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Flower
    {
        #region Fields
        private int _id;
        private string _name;
        private FlowerRarity _rarity;
        private Bitmap _image;
        #endregion
        #region Propertie
        public int Id => _id;
        public string Name => _name;
        public FlowerRarity Rarity => _rarity;
        public Bitmap Image => _image;
        #endregion
        public Flower(FlowerRarityNaming flowerRarity, int id)
        {
            switch (flowerRarity)
            {
                case FlowerRarityNaming.Common:
                    _id = id;
                    _name = "Common Flower";
                    _rarity = new FlowerRarity(FlowerRarityNaming.Common, 1);
                    //image
                    break;
                case FlowerRarityNaming.Rare:
                    _id = id;
                    _name = "Rare Flower";
                    _rarity = new FlowerRarity(FlowerRarityNaming.Rare, 1.5);
                    //image
                    break;
                case FlowerRarityNaming.Elite:
                    _id = id;
                    _name = "Elite Flower";
                    _rarity = new FlowerRarity(FlowerRarityNaming.Elite, 2);
                    //image
                    break;
            }
        }
    }
}
