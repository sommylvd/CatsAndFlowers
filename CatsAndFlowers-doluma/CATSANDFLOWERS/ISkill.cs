using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATSANDFLOWERS
{
    public interface ISkill
    {
        SkillName SkillName { get; } //будущий енам
        CatQualificationNames SkillLevel { get; set; }
        double SkillValue { get; set; }
    }
    public class FlowersPicking : ISkill
    {
        private CatQualificationNames _skillLevel;
        private double _skillValue;

        public FlowersPicking(CatQualificationNames skillLevel, double skillValue)
        {
            _skillLevel = skillLevel;
            _skillValue = skillValue;
        }

        public SkillName SkillName { get => SkillName.FlowersPicking; }
        public CatQualificationNames SkillLevel { get => _skillLevel; set => _skillLevel = value; }
        public double SkillValue { get => _skillValue; set => _skillValue = value; }
    }
    public class WreathWeaving : ISkill
    {
        private CatQualificationNames _skillLevel;
        private double _skillValue;

        public WreathWeaving(CatQualificationNames skillLevel, double skillValue)
        {
            _skillLevel = skillLevel;
            _skillValue = skillValue;
        }

        public SkillName SkillName { get => SkillName.WreathWeaving; }
        public CatQualificationNames SkillLevel { get => _skillLevel; set => _skillLevel = value; }
        public double SkillValue { get => _skillValue; set => _skillValue = value; }
    }
    public enum CatQualificationNames
    {
        Beginner,
        Advanced,
        Professional,
        Master
    }
    public enum SkillName {
        FlowersPicking,
        WreathWeaving
    }

}
