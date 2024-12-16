using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
namespace CATSANDFLOWERS
{
    public class Flower
    {
        #region Fields
        private int _id;
        private string _name;
        private FlowerRarity _rarity;
        private Bitmap _image;
        #endregion
        #region Properties
        public int Id => _id;
        public string Name => _name;
        public FlowerRarity Rarity => _rarity;
        public Bitmap Image => _image;
        #endregion
    }
}
