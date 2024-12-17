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
    }
}
