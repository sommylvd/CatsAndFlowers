using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class FlowerRarity
    {
        #region Fields
        private FlowerRarityNaming _rarityName; //будет енам
        private double _boostPrice;
        public FlowerRarity(FlowerRarityNaming rarityName, double boostPrice)
        {
            _rarityName = rarityName;
            _boostPrice = boostPrice;
        }
        //private double _detectionDifficulty;
        #endregion
        #region Properties
        public FlowerRarityNaming RarityName => _rarityName;
        public double BoostPrice => _boostPrice;
        //public double DetectionDifficulty => _detectionDifficulty;
        #endregion
    }
    public enum FlowerRarityNaming
    {
        Common,
        Rare,
        Elite
    }

}
