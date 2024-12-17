using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATSANDFLOWERS
{
    public class Cat
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public WorkPlaceName WorkType { get; set; } // Тип выполняемой работы котом 
        public CatQualification SkillLevel { get; set; } // Уровень квалификации
        public double Price { get; set; }
        public int WorkSpeed { get; set; } // Скорость
        public double QuantityBoost { get; set; } // Количество
        public Bitmap Image { get; set; }
        #endregion
        #region Methods
        public void GetInfo() { }
        #endregion
        public Cat(CatQualificationNames qualificationNames, WorkPlaceName workPlaceName, string name, int id) 
        {
            if (workPlaceName == WorkPlaceName.FlowerMeadow)
            {
                Id = id;
                Name = name;
                WorkType = workPlaceName;
                SkillLevel = new CatQualification(SkillName.FlowersPicking, qualificationNames);
                Price = 200 * SkillLevel.Price;
                WorkSpeed = SkillLevel.WorkSpeed;
                QuantityBoost = SkillLevel.QualificationName.SkillValue;
                Image = null;
            }
            else if (workPlaceName == WorkPlaceName.CraftMeadow) {
                Id = id;
                Name = name;
                WorkType = workPlaceName;
                SkillLevel = new CatQualification(SkillName.WreathWeaving, qualificationNames);
                Price = 200 * SkillLevel.Price;
                WorkSpeed = SkillLevel.WorkSpeed;
                QuantityBoost = SkillLevel.QualificationName.SkillValue;
                Image = null;
            }
        }
    }
}
