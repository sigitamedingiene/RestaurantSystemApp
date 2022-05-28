

namespace Business_Class
{
    public class Food    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Food(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
