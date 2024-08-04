using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GUI_DigitalStore
{
    public class Store
    {
        
        private List<Item> productsList;
        public List<Buyer> buyersList { get; set; }
        public List<Merchant> merchantsList { get; set; }

        public Store()
        {
            buyersList = new List<Buyer>();
            merchantsList = new List<Merchant>();
            productsList = new List<Item>();
        }

        public void AddBuyer(Buyer buyer)
        {
            if (buyer == null)
            {
                throw new ArgumentNullException(nameof(buyer), "Buyer cannot be null.");
            }

            buyersList.Add(buyer);
            Console.WriteLine("Buyer added successfully.");
        }

        public void AddMerchant(Merchant merchant)
        {
            if (merchant == null)
            {
                throw new ArgumentNullException(nameof(merchant), "Merchant cannot be null.");
            }

            merchantsList.Add(merchant);
            Console.WriteLine("Merchant added successfully.");
        }

        public void AddProduct(Item product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            }

            productsList.Add(product);
            Console.WriteLine("Product added successfully.");
        }

        public Buyer FindBuyerByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Name cannot be null or empty.");
            }

            foreach (Buyer buyer in buyersList)
            {
                if (buyer != null && buyer.Name == name)
                {
                    return buyer;
                }
            }
            return null;
        }

        public Merchant FindMerchantByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Name cannot be null or empty.");
            }

            foreach (Merchant merchant in merchantsList)
            {
                if (merchant != null && merchant.Name == name)
                {
                    return merchant;
                }
            }
            return null;
        }

        public void AddProductToBuyerCart(string buyerName, string productName, string merchantName)
        {
            Buyer buyer = FindBuyerByName(buyerName);

            if (buyer == null)
            {
                throw new ArgumentException("Buyer not found!");
            }

            Merchant merchant = FindMerchantByName(merchantName);

            if (merchant == null)
            {
                throw new ArgumentException("Merchant not found!");
            }

            Item product = merchant.FindProductByName(productName);

            if (product == null)
            {
                throw new ArgumentException("Product not found with this merchant!");
            }

            buyer.AddToCart(product);
            Console.WriteLine("Product added to buyer's cart successfully.");
        }

        public void PayOrder(ref Store store)
        {
            Console.WriteLine("Enter buyer's name:");
            string buyerName = Console.ReadLine();

            Buyer buyer = store.FindBuyerByName(buyerName);

            if (buyer == null)
            {
                throw new ArgumentException("Buyer not found!");
            }

            List<Item> cart = buyer.shoppingCart;

            if (cart.Count <= 1)
            {
                throw new InvalidOperationException("Cannot place an order with only one item in the cart.");
            }

            double totalPrice = 0;
            foreach (Item item in cart)
            {
                if (item != null)
                {
                    totalPrice += item.Price + ((item is PackagedItem) ? ((PackagedItem)item).AddedPrice : 0);
                }
            }

            Order order = new Order(cart, totalPrice, buyer);
            order.Pay();

            buyer.AddOrderToHistory(order);
            buyer.ClearCart();

            Console.WriteLine("Order has been paid and added to the order history.");
        }

        public void ShowAllBuyersData(Store store)
        {
            Console.WriteLine("All Buyers Data:");

            foreach (Buyer buyer in store.GetBuyersList())
            {
                if (buyer != null)
                {
                    Console.WriteLine($"Buyer Name: {buyer.Name}");
                    Console.WriteLine($"Buyer Address: {buyer.Adress.PrintAdress()}");
                    Console.WriteLine($"Buyer Cart Items:");
                    foreach (Item item in buyer.shoppingCart)
                    {
                        if (item != null)
                        {
                            Console.WriteLine(item.PrintItem());
                        }
                    }
                    Console.WriteLine($"Order History:");
                    foreach (Order order in buyer.ordersList)
                    {
                        if (order != null)
                        {
                            Console.WriteLine(order.PrintOrder());
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        public void ShowAllMerchantsData(Store store)
        {
            Console.WriteLine("All Merchants Data:");

            // מיון המוכרים לפי מספר הפריטים שהם מוכרים
            List<Merchant> sortedMerchants = new List<Merchant>(merchantsList);
            sortedMerchants.Sort(new MerchantComparer());

            foreach (Merchant merchant in sortedMerchants)
            {
                if (merchant != null)
                {
                    Console.WriteLine($"Merchant Name: {merchant.Name}");
                    Console.WriteLine($"Merchant Address: {merchant.Adress.PrintAdress()}");
                    Console.WriteLine($"Merchant Products:");
                    merchant.PrintProducts();
                    Console.WriteLine();
                }
            }
        }

        public List<Buyer> GetBuyersList()
        {
            return buyersList;
        }

        public List<Merchant> GetMerchantsList()
        {
            return merchantsList;
        }

        public void ShowAllProducts()
        {
            Console.WriteLine("Available products in the store:");
            foreach (Merchant merchant in merchantsList)
            {
                if (merchant != null)
                {
                    foreach (Item product in merchant.ProductsList)
                    {
                        if (product != null)
                        {
                            Console.WriteLine($"Product: {product.Name}, Price: {product.Price}, Category: {product.Category}, Merchant: {merchant.Name}");
                        }
                    }
                }
            }
        }

        public void CompareBuyers(string buyerName1, string buyerName2)
        {
            Buyer buyer1 = FindBuyerByName(buyerName1);
            Buyer buyer2 = FindBuyerByName(buyerName2);

            if (buyer1 == null || buyer2 == null)
            {
                throw new ArgumentException("One or both buyers not found!");
            }

            if (buyer1 > buyer2)
            {
                Console.WriteLine($"{buyer1.Name} has a higher total in their shopping cart than {buyer2.Name}.");
            }
            else if (buyer1 < buyer2)
            {
                Console.WriteLine($"{buyer2.Name} has a higher total in their shopping cart than {buyer1.Name}.");
            }
            else
            {
                Console.WriteLine($"{buyer1.Name} and {buyer2.Name} have the same total in their shopping carts.");
            }
        }

        public static Store operator +(Store store, Buyer buyer)
        {
            store.AddBuyer(buyer);
            return store;
        }

        public static Store operator +(Store store, Merchant merchant)
        {
            store.AddMerchant(merchant);
            return store;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Store other = (Store)obj;
            return buyersList.Equals(other.buyersList) && merchantsList.Equals(other.merchantsList) && productsList.Equals(other.productsList);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(buyersList, merchantsList, productsList).GetHashCode();
        }
    }

    // מחלקה להשוואת מוכרים לפי מספר הפריטים
    internal class MerchantComparer : IComparer<Merchant>
    {
        public int Compare(Merchant merchant1, Merchant merchant2)
        {
            if (merchant1 == null || merchant2 == null)
            {
                throw new ArgumentException("Objects being compared must be of type Merchant.");
            }

            return merchant2.ProductsList.Count - merchant1.ProductsList.Count;
        }
    }
}
