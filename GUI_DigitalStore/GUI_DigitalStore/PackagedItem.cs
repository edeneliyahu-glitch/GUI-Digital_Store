using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_DigitalStore
{
    public class PackagedItem : Item
    {
        private double addedPrice;

        public PackagedItem(string name, double price, ProductCategory category, double addedPrice)
            : base(name, price, category)
        {
            AddedPrice = addedPrice;
        }

        private bool IsValidAddedPrice(double addedPrice)
        {
            if (addedPrice < 0)
            {
                Console.WriteLine("Added price must be positive.");
                return false;
            }
            return true;
        }

        public double AddedPrice
        {
            get { return addedPrice; }
            set
            {
                while (!IsValidAddedPrice(value))
                {
                    Console.WriteLine("Enter added packaging price: ");
                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Invalid input. Enter a valid price: ");
                    }
                }
                addedPrice = value;
            }
        }

        public override string PrintItem()
        {
            return base.PrintItem() + $", Added packaging price: {AddedPrice}";
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            PackagedItem other = (PackagedItem)obj;
            return AddedPrice == other.AddedPrice;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(base.GetHashCode(), AddedPrice).GetHashCode();
        }
    }
}
