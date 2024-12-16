using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATSANDFLOWERS
{
    public class CatWorkType
    {
        #region Fields

        private string _nameType; //возможно будет енам
        private IWorkplace _workPlace;
        #endregion
        #region Properties 
        public string NameType=>_nameType;
        public IWorkplace WorkPlace => _workPlace;
        #endregion
    }
}
