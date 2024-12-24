using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ClassShop
    {
        private Bitmap _shopCatBitmap;
        private List<Cat> _shopCatList;
        private int _price;

    }
    public class ShopCat
    {
        Player player;
        public int countCats = 0;

        public ShopCat(Player player)
        {
            this.player = player;
        }

        public Cat BuyBeginnerCatFl()
        {
            Cat beginnerCat = new Cat(CatQualificationNames.Beginner, WorkPlaceName.FlowerMeadow, $"{countCats}. beginnerCat", countCats);
            if ((player.Money -= beginnerCat.Price) >= 0)
            {
                player.Money -= beginnerCat.Price;
                countCats++;
                return beginnerCat;
            }
            return null;

        }

        public Cat BuyAdvancedCatFl()
        {
            Cat advancedCat = new Cat(CatQualificationNames.Advanced, WorkPlaceName.FlowerMeadow, $"{countCats}. advancedCat", countCats);
            if ((player.Money -= advancedCat.Price) >= 0)
            {
                player.Money -= advancedCat.Price;
                countCats++;
                return advancedCat;
            }
            return null;

        }

        public Cat BuyProfessionalCatFl()
        {
            Cat professionalCat = new Cat(CatQualificationNames.Professional, WorkPlaceName.FlowerMeadow, $"{countCats}. professionalCat", countCats);
            if ((player.Money -= professionalCat.Price) >= 0)
            {
                player.Money -= professionalCat.Price;
                countCats++;
                return professionalCat;
            }
            return null;

        }

        public Cat BuyMasterlCatFl()
        {
            Cat masterCat = new Cat(CatQualificationNames.Master, WorkPlaceName.FlowerMeadow, $"{countCats}. masterCat", countCats);
            if ((player.Money -= masterCat.Price) >= 0)
            {
                player.Money -= masterCat.Price;
                countCats++;
                return masterCat;
            }
            return null;
        }

        public Cat BuyBeginnerCatCr()
        {
            Cat beginnerCat = new Cat(CatQualificationNames.Beginner, WorkPlaceName.CraftMeadow, $"{countCats}. beginnerCat", countCats);
            if ((player.Money -= beginnerCat.Price) >= 0)
            {
                player.Money -= beginnerCat.Price;
                countCats++;
                return beginnerCat;
            }
            return null;

        }

        public Cat BuyAdvancedCatCr()
        {
            Cat advancedCat = new Cat(CatQualificationNames.Advanced, WorkPlaceName.CraftMeadow, $"{countCats}. advancedCat", countCats);
            if ((player.Money -= advancedCat.Price) >= 0)
            {
                player.Money -= advancedCat.Price;
                countCats++;
                return advancedCat;
            }
            return null;

        }

        public Cat BuyProfessionalCatCr()
        {
            Cat professionalCat = new Cat(CatQualificationNames.Professional, WorkPlaceName.CraftMeadow, $"{countCats}. professionalCat", countCats);
            if ((player.Money -= professionalCat.Price) >= 0)
            {
                player.Money -= professionalCat.Price;
                countCats++;
                return professionalCat;
            }
            return null;

        }

        public Cat BuyMasterlCatCr()
        {
            Cat masterCat = new Cat(CatQualificationNames.Master, WorkPlaceName.CraftMeadow, $"{countCats}. masterCat", countCats);
            if ((player.Money -= masterCat.Price) >= 0)
            {
                player.Money -= masterCat.Price;
                countCats++;
                return masterCat;
            }
            return null;
        }
    }
}
