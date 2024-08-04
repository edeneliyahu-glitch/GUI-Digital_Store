using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_DigitalStore
{
    public class Item
    {
        public enum ProductCategory
        {
            Children = 1,
            Electricity = 2,
            Office = 3,
            Clothing = 4
        }

            private static int nextId = 1;
            private int itemId;
            private string name;
            private double price;
            private ProductCategory category;

            public Item(string name, double price, ProductCategory category)
            {
                ItemId = nextId++;
                Name = name;
                Price = price;
                Category = category;
            }

            private bool IsValidName(string name)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name cannot be null or empty.");
                    return false;
                }
                return true;
            }

            private bool IsValidPrice(double price)
            {
                if (price <= 0)
                {
                    Console.WriteLine("Price must be positive.");
                    return false;
                }
                return true;
            }

            private bool IsValidCategory(ProductCategory category)
            {
                if (!Enum.IsDefined(typeof(ProductCategory), category))
                {
                    Console.WriteLine("Invalid category.");
                    return false;
                }
                return true;
            }

            public int ItemId { get; private set; }

            public string Name
            {
                get { return name; }
                set
                {
                    while (!IsValidName(value))
                    {
                        Console.WriteLine("Enter item name: ");
                        value = Console.ReadLine();
                    }
                    name = value;
                }
            }

            public double Price
            {
                get { return price; }
                set
                {
                    while (!IsValidPrice(value))
                    {
                        Console.WriteLine("Enter item price: ");
                        if (!double.TryParse(Console.ReadLine(), out value))
                        {
                            Console.WriteLine("Invalid input. Enter a valid price: ");
                        }
                    }
                    price = value;
                }
            }

            public ProductCategory Category
            {
                get { return category; }
                set
                {
                    while (!IsValidCategory(value))
                    {
                        Console.WriteLine("Enter item category (1-Children, 2-Electricity, 3-Office, 4-Clothing): ");
                        int categoryChoice;
                        while (!int.TryParse(Console.ReadLine(), out categoryChoice) || !IsValidCategory((ProductCategory)categoryChoice))
                        {
                            Console.WriteLine("Invalid category. Enter a valid category (1-Children, 2-Electricity, 3-Office, 4-Clothing): ");
                        }
                        value = (ProductCategory)categoryChoice;
                    }
                    category = value;
                }
            }

            public virtual string PrintItem()
            {
                string categoryString = Category.ToString();
                return $"The item is: {Name}, Id number: {ItemId}, From Category: {categoryString}, Price: {Price}";
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Item other = (Item)obj;
                return Name == other.Name && Price == other.Price && Category == other.Category;
            }

            public override int GetHashCode()
            {
                return Tuple.Create(Name, Price, Category).GetHashCode();
            }
        }
    }
