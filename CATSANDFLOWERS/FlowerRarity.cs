using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATSANDFLOWERS
{
    public class FlowerRarity
    {
        #region Fields
        private string _rarityName; //будет енам
        private double _boostPrice;
        private double _detectionDifficulty;
        #endregion
        #region Properties
        public string RarityName => _rarityName;
        public double BoostPrice => _boostPrice;
        public double DetectionDifficulty => _detectionDifficulty;
        #endregion
    }
}
