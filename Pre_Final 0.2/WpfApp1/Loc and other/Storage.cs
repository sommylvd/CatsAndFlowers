using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public static class Storage
    {
        private static Random _random = new Random(DateTime.Now.Millisecond);
        private static int _flowerId = 0;
        private static int _wreathId = 0;
        public static Dictionary<WreathTypeName, WreathType> requariments
            = new Dictionary<WreathTypeName, WreathType>
            {{WreathTypeName.Easy,new WreathType(WreathTypeName.Easy)},
            {WreathTypeName.Medium,new WreathType(WreathTypeName.Medium)},
            {WreathTypeName.Hard,new WreathType(WreathTypeName.Hard)}};



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
                    if (rand < 30) return new Flower(FlowerRarityNaming.Common, _flowerId);
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

        public static bool CheckRequariments(Player player, WreathTypeName typeName)
        {
            switch (typeName)
            {
                case WreathTypeName.Easy:
                    if (player.InfoFlower()[FlowerRarityNaming.Common] >= requariments[typeName].FlowersRequirements[FlowerRarityNaming.Common])
                        return true;
                    else
                        return false;
                case WreathTypeName.Medium:
                    if (player.InfoFlower()[FlowerRarityNaming.Common] >= requariments[typeName].FlowersRequirements[FlowerRarityNaming.Common]
                        && player.InfoFlower()[FlowerRarityNaming.Rare] >= requariments[typeName].FlowersRequirements[FlowerRarityNaming.Rare])
                        return true;
                    else
                        return false;
                case WreathTypeName.Hard:
                    if (player.InfoFlower()[FlowerRarityNaming.Common] >= requariments[typeName].FlowersRequirements[FlowerRarityNaming.Common]
                        && player.InfoFlower()[FlowerRarityNaming.Rare] >= requariments[typeName].FlowersRequirements[FlowerRarityNaming.Rare]
                        && player.InfoFlower()[FlowerRarityNaming.Elite] >= requariments[typeName].FlowersRequirements[FlowerRarityNaming.Elite])
                        return true;
                    else
                        return false;
            }
            return false;
        }

        public static Wreath Creating(ISkill skill, WreathTypeName typeName)
        {
            return new Wreath(typeName, _wreathId);
        }

    }

}

