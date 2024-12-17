using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public abstract class Cat
    {
        #region Properties
        public abstract int Id { get; set; }
        public abstract CatWorkType WorkType { get; set; } //Тип выполняемой работы котом 
        public abstract CatQualification SkillLevel { get; set; } //Уровень квалификации
        public abstract int Price { get; set; }
        public abstract int WorkSpeed { get; set; } //Скорость
        public abstract int QuantityBoost { get; set; } //Количество
        public abstract Bitmap Image { get; set; }
        #endregion
        #region Methods
        public abstract void GetInfo();
        #endregion
    }
}
