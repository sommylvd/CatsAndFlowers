using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace CATSANDFLOWERS
{
    public static class Storage
    {
        private static Random _random = new Random(DateTime.Now.Millisecond);
        private static int _flowerId = 0;
        public static Flower PickFlower(ISkill skill)
        {
            int rand = 0;
            switch (skill.SkillLevel)
            {
                case CatQualificationNames.Beginner:
                    rand = _random.Next(0, 100);
                    if (rand < 90) return new Flower(FlowerRarityNaming.Common, _flowerId);
                    else return new Flower(FlowerRarityNaming.Rare, _flowerId);
                case CatQualificationNames.Advanced:
                    rand = _random.Next(0, 100);
                    if (rand < 60) return new Flower(FlowerRarityNaming.Common, _flowerId);
                    else
                    {
                        rand = _random.Next(0, 100);
                        if (rand < 80) return new Flower(FlowerRarityNaming.Rare, _flowerId);
                        else return new Flower(FlowerRarityNaming.Elite, _flowerId);
                    }
                case CatQualificationNames.Professional:
                    rand = _random.Next(0, 100);
                    if (rand < 30) return new Flower(FlowerRarityNaming.Common,_flowerId);
                    else
                    {
                        rand = _random.Next(0, 100);
                        if (rand < 50) return new Flower(FlowerRarityNaming.Rare, _flowerId);
                        else return new Flower(FlowerRarityNaming.Elite, _flowerId);
                    }
                case CatQualificationNames.Master:
                    rand = _random.Next(0, 100);
                    if (rand < 60) return new Flower(FlowerRarityNaming.Rare, _flowerId);
                    else return new Flower(FlowerRarityNaming.Elite, _flowerId);
               
            }
            return new Flower(FlowerRarityNaming.Common, 9999);    
        }
    }
}
