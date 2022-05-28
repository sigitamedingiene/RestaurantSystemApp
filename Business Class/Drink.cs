

namespace Business_Class
{
    public class Drink
    {   public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Capacity { get; set; }
        public Drink(string name, decimal price, decimal capacity)
        {
            Name = name;
            Price = price;
            Capacity = capacity;
        }
    }
}
