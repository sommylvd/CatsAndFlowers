using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATSANDFLOWERS
{
    public class CatRarity
    {
        #region Fields
        private string _rarityName; //будет енам
        private int _price;
        private int _workSpeed;
        #endregion
        #region Properties
        public string RarityName=>_rarityName;
        public int Price => _price;
        public int WorkSpeed => _workSpeed;
        #endregion
    }
}
