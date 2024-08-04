using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GUI_DigitalStore
{
    public class Buyer : User
    {

        public List<Item> shoppingCart { get; private set; }
        public List<Order> ordersList { get; private set; }

        public Buyer(string name, string password, Adress adress)
            :base(name, password, adress)
        {
            shoppingCart = new List<Item>();
            ordersList = new List<Order>();
        }

        public void AddToCart(Item item)
        {
            if (item == null)
            {
                Console.WriteLine("Cannot add null item to cart.");
                return;
            }

            shoppingCart.Add(item);
            Console.WriteLine("Item added to the cart successfully.");
        }

        public void SetCartList(List<Item> cart)
        {
            if (cart == null)
            {
                Console.WriteLine("Cannot set cart list to null.");
                return;
            }
            shoppingCart = cart;
        }

        public void AddOrderToHistory(Order order)
        {
            ordersList.Add(order);
            Console.WriteLine("Order added to history.");
        }

        public void ClearCart()
        {
            shoppingCart = new List<Item>();
            Console.WriteLine("Cart cleared successfully.");
        }

        public void CreateNewCartFromHistory(int orderIndex)
        {
            if (orderIndex < 0 || orderIndex >= ordersList.Count)
            {
                throw new ArgumentException("Invalid order index.");
            }

            Order selectedOrder = ordersList[orderIndex];
            shoppingCart = new List<Item>(selectedOrder.Items);
            Console.WriteLine("New shopping cart created from order history.");
        }

        public void PrintOrderHistory()
        {
            for (int i = 0; i < ordersList.Count; i++)
            {
                Order order = ordersList[i];
                Console.WriteLine($"Order {i}:");
                Console.WriteLine(order.PrintOrder());
            }
        }

        public static bool operator >(Buyer buyer1, Buyer buyer2)
        {
            return buyer1.GetCartTotal() > buyer2.GetCartTotal();
        }

        public static bool operator <(Buyer buyer1, Buyer buyer2)
        {
            return buyer1.GetCartTotal() < buyer2.GetCartTotal();
        }

        private double GetCartTotal()
        {
            double total = 0;
            foreach (Item item in shoppingCart)
            {
                if (item != null)
                {
                    total += item.Price + ((item is PackagedItem) ? ((PackagedItem)item).AddedPrice : 0);
                }
            }
            return total;
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            Buyer other = (Buyer)obj;
            return shoppingCart.Equals(other.shoppingCart) && ordersList.Equals(other.ordersList);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(base.GetHashCode(), shoppingCart, ordersList).GetHashCode();
        }
    }
}
