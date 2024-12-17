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
        private ISkill _qualificationName; 
        private double _price;
        private int _workSpeed;
        #endregion
        #region Properties
        public ISkill QualificationName => _qualificationName;
        public double Price => _price;
        public int WorkSpeed => _workSpeed;
        #endregion
        public CatQualification(SkillName skillName, CatQualificationNames qualificationNames)
        {
            switch (skillName) {
                case SkillName.FlowersPicking:
                    switch(qualificationNames)
                    {
                        case CatQualificationNames.Beginner:
                            _qualificationName = new FlowersPicking(qualificationNames, 1);
                            _price = 1;
                            _workSpeed = 1;
                            break;
                        case CatQualificationNames.Advanced:
                            _qualificationName = new FlowersPicking(qualificationNames, 1.2);
                            _price = 1.2;
                            _workSpeed = 2;
                            break;
                        case CatQualificationNames.Professional:
                            _qualificationName = new FlowersPicking(qualificationNames, 1.5);
                            _price = 1.5;
                            _workSpeed = 3;
                            break;
                        case CatQualificationNames.Master:
                            _qualificationName = new FlowersPicking(qualificationNames, 1.8);
                            _price = 1.8;
                            _workSpeed = 4;
                            break;
                    }
                    break;
                case SkillName.WreathWeaving:
                    switch (qualificationNames)
                    {
                        case CatQualificationNames.Beginner:
                            _qualificationName = new FlowersPicking(qualificationNames, 1);
                            _price = 1;
                            _workSpeed = 1;
                            break;
                        case CatQualificationNames.Advanced:
                            _qualificationName = new FlowersPicking(qualificationNames, 1.2);
                            _price = 1.2;
                            _workSpeed = 2;
                            break;
                        case CatQualificationNames.Professional:
                            _qualificationName = new FlowersPicking(qualificationNames, 1.5);
                            _price = 1.5;
                            _workSpeed = 3;
                            break;
                        case CatQualificationNames.Master:
                            _qualificationName = new FlowersPicking(qualificationNames, 1.8);
                            _price = 1.8;
                            _workSpeed = 4;
                            break;
                    }
                    break;

            }
        }
    }
}
