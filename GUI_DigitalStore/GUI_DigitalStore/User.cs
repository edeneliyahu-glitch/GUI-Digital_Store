using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_DigitalStore
{
    public class User
    {
        
        private string name;
        private string password;
        private Adress adress;

        public User(string name, string password, Adress adress)
        {
            Name = name;
            Password = password;
            Adress = adress;
        }


        private bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Password cannot be null or empty.");
                return false;
            }
            return true;
        }

        private bool IsValidAdress(Adress adress)
        {
            if (adress == null)
            {
                Console.WriteLine("Address cannot be null.");
                return false;
            }
            return true;
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                while (!IsValidPassword(value))
                {
                    Console.WriteLine("Enter a valid password: ");
                    value = Console.ReadLine();
                }
                password = value;
            }
        }

        public Adress Adress
        {
            get { return adress; }
            set
            {
                while (!IsValidAdress(value))
                {
                    Console.WriteLine("Enter address details again.");
                    Console.WriteLine("Street: ");
                    string street = Console.ReadLine();
                    Console.WriteLine("City: ");
                    string city = Console.ReadLine();
                    Console.WriteLine("Country: ");
                    string country = Console.ReadLine();
                    Console.WriteLine("Building Number: ");
                    int buildingNum;
                    while (!int.TryParse(Console.ReadLine(), out buildingNum))
                    {
                        Console.WriteLine("Invalid input. Enter a valid building number: ");
                    }
                    value = new Adress(street, city, country, buildingNum);
                }
                adress = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            User other = (User)obj;
            return name == other.name && password == other.password && adress.Equals(other.adress);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(name, password, adress).GetHashCode();
        }
    }
}

