using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public interface ISkill
    {
        string SkillName { get; } //будущий енам
        CatQualificationNames SkillLevel { get; set; }
        double SkillValue { get; set; }
    }
    public class FlowersPicking : ISkill
    {
        private CatQualificationNames _skillLevel;
        private double _skillValue;
        public string SkillName { get => "FlowersPicking"; }
        public CatQualificationNames SkillLevel { get => _skillLevel; set => _skillLevel = value; }
        public double SkillValue { get => _skillValue; set => _skillValue = value; }
    }
    public class WreathWeaving : ISkill
    {
        private CatQualificationNames _skillLevel;
        private double _skillValue;
        public string SkillName { get => "WreathWeaving"; }
        public CatQualificationNames SkillLevel { get => _skillLevel; set => _skillLevel = value; }
        public double SkillValue { get => _skillValue; set => _skillValue = value; }
    }
}
