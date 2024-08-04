using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_DigitalStore
{
    public class Order
    {
        private List<Item> items;
        private double totalPrice;
        private Buyer buyer;

        public Order(List<Item> items, double totalPrice, Buyer buyer)
        {
            this.items = items;
            this.totalPrice = totalPrice;
            this.buyer = buyer;
        }

        public void Pay()
        {
            Console.WriteLine($"Order paid. Total amount: {totalPrice}");
        }

        public string PrintOrder()
        {
            string orderDetails = $"Order for {buyer.Name}:\nTotal Price: {totalPrice}\nItems:\n";
            foreach (Item item in items)
            {
                if (item != null)
                {
                    orderDetails += item.PrintItem() + "\n";
                }
            }
            return orderDetails;
        }

        public List<Item> Items
        {
            get { return items; }
        }

        public double TotalPrice
        {
            get { return totalPrice; }
        }

        public Buyer Buyer
        {
            get { return buyer; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Order other = (Order)obj;
            return items.Equals(other.items) && totalPrice == other.totalPrice && buyer.Equals(other.buyer);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(items, totalPrice, buyer).GetHashCode();
        }
    }
}
