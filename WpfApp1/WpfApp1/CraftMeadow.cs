using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class CraftMeadow: IWorkplace
    {
        #region Fields
        private Bitmap _image;
        private List<Cat> _catsWorkersList;
        #endregion
        #region Properties
        public List<Cat> catsWorkers { get => _catsWorkersList; set => _catsWorkersList = value; }
        public Bitmap Image { get => _image; set => _image = value; }
        #endregion
    }
}
