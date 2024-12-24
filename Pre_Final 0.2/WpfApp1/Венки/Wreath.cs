using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Wreath
    {
        #region Fields
        private int _id;
        private int _price;
        private WreathType _wreathType;
        private Bitmap _wreathImage;
        #endregion
        #region Properties
        public int Id => _id;
        public WreathType WreathType => _wreathType;
        public int Price => _price;
        public Bitmap WreathImage => _wreathImage;
        #endregion
        public Wreath(WreathTypeName wreathTypeName, int id)
        {
            switch (wreathTypeName)
            {
                case WreathTypeName.Easy:
                    _id = id;
                    _wreathType = new WreathType(wreathTypeName);
                    _price = 30;
                    _wreathImage = null;
                    break;
                case WreathTypeName.Medium:
                    _id = id;
                    _wreathType = new WreathType(wreathTypeName);
                    _price = 60;
                    _wreathImage = null;
                    break;
                case WreathTypeName.Hard:
                    _id = id;
                    _wreathType = new WreathType(wreathTypeName);
                    _price = 90;
                    _wreathImage = null;
                    break;
            }
        }
    }
}

