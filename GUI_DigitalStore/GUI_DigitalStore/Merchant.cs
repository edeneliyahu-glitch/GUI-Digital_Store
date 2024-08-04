using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GUI_DigitalStore
{
    public class Merchant : User
    {
        public List<Item> productsList { get; private set; }

        public Merchant(string name, string password, Adress adress)
            : base(name, password, adress)
        {
            productsList = new List<Item>();
        }

        public void AddProduct(ref Item product)
        {
            if (product == null)
            {
                Console.WriteLine("Cannot add null product.");
                return;
            }

            productsList.Add(product);
            Console.WriteLine("Product added successfully.");
        }

        public Item FindProductByName(string name)
        {
            foreach (Item product in productsList)
            {
                if (product != null && product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }

        public void PrintProducts()
        {
            foreach (Item product in productsList)
            {
                if (product != null)
                {
                    Console.WriteLine(product.PrintItem());
                }
            }
        }

        public List<Item> ProductsList
        {
            get { return productsList; }
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            Merchant other = (Merchant)obj;
            return productsList.Equals(other.productsList);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(base.GetHashCode(), productsList).GetHashCode();
        }
    }
}
