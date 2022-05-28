using System;


namespace Business_Class
{
    public class Order    {
        public int Id { get; }
        public Food Food { get; }
        public Drink Drink { get; }
        public decimal Total { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime PaymentTime { get; set; }
        public Order(int id, Food food, Drink drink, decimal total, DateTime dateTimeCreated, DateTime paymentTime)
        {
            Id = id;
            Food = food;
            Drink = drink;
            Total = total;
            DateTimeCreated = dateTimeCreated;
            PaymentTime = paymentTime;
            

        }
        public decimal TotalPrice(Food food, Drink drink)
        {
            return Total = Food.Price + Drink.Price;
        }
    }
}
