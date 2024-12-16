using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATSANDFLOWERS
{
    public class Skill
    {
        #region Fields
        private string _skillName;
        private double _skillValue;
        #endregion
        #region Properties 
        public string SkillName =>_skillName;
        public double SkillValue =>_skillValue;
        #endregion
    }
}
