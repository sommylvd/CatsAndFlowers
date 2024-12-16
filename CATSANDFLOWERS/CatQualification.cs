using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATSANDFLOWERS
{
    public class CatQualification
    {
        #region Fields
        private CatQualificationNames _qualificationName; 
        private int _price;
        private int _workSpeed;
        #endregion
        #region Properties
        public CatQualificationNames QualificationName => _qualificationName;
        public int Price => _price;
        public int WorkSpeed => _workSpeed;
        #endregion
    }
   public enum CatQualificationNames
    {
        Beginner,
        Advanced,
        Professional,
        Master
    }
}
