using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class CatWorkType
    {
        #region Fields
        private IWorkplace _workPlace;
        #endregion
        #region Properties 
        public IWorkplace WorkPlace => _workPlace;
        public string NameType => _workPlace.WorkPlaceName.ToString();
        #endregion

    }
}
