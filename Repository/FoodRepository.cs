using Business_Class;
using System.Collections.Generic;

namespace Repository
{
    public class FoodRepository
    {
        private List<Food> FoodList { get; }
        public FoodRepository()
        {
            FoodList = new List<Food>();
            FoodList.Add(new Food("Blynai", 2.99m));
            FoodList.Add(new Food("Kepta duona", 4.99m));
            FoodList.Add(new Food("Žirniai su spirgučiais", 3.99m));

        }
        public List<Food> Retrieve()
        {
            return FoodList;
        }
    }
}
