using Business_Class;
using System.Collections.Generic;

namespace Repository
{
    public class DrinksRepository    {
        private List<Food> DrinksList { get; }
        public DrinksRepository()
        {
            DrinksList = new List<Food>();
            DrinksList.Add(new Food("Alus", 4.00m));
            DrinksList.Add(new Food("Gira", 2.50m));
            DrinksList.Add(new Food("Arbata", 2.20m));
        }
        public List<Food> Retrieve()
        {
            return DrinksList;
        }
    }
}
