using System.Collections.Generic;

namespace VendorOrder.Models
{
    public class Order
    {
        public string Description { get; set; }
        public int Id { get; }
        public int Price {get;set;}
        public string Day{get;set;}
        private static List<Order> _instances = new List<Order> { };

        public Order(string description, int price, string day)
        {
            Description = description;
            Price = price;
            Day = day;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order Find(int searchId)
        {
            return _instances[searchId - 1];
        }

    }
}