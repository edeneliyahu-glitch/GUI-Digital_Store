using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_DigitalStore
{
    public class Adress
    {
            private string street;
            private string city;
            private string country;
            private int buildingNum;

            public Adress(string street, string city, string country, int buildingNum)
            {
                Street = street;
                City = city;
                Country = country;
                BuildingNum = buildingNum;
            }

            public Adress(Adress other)
            {
                City = other.City;
                Street = other.Street;
                BuildingNum = other.BuildingNum;
                Country = other.Country;
            }

            private bool IsValidStreet(string street)
            {
                if (string.IsNullOrWhiteSpace(street))
                {
                    Console.WriteLine("Street cannot be null or empty.");
                    return false;
                }
                return true;
            }

            private bool IsValidCity(string city)
            {
                if (string.IsNullOrWhiteSpace(city))
                {
                    Console.WriteLine("City cannot be null or empty.");
                    return false;
                }
                return true;
            }

            private bool IsValidCountry(string country)
            {
                if (string.IsNullOrWhiteSpace(country))
                {
                    Console.WriteLine("Country cannot be null or empty.");
                    return false;
                }
                return true;
            }

            private bool IsValidBuildingNum(int buildingNum)
            {
                if (buildingNum <= 0)
                {
                    Console.WriteLine("Building number must be a positive number.");
                    return false;
                }
                return true;
            }

            public string Street
            {
                get { return street; }
                set
                {
                    while (!IsValidStreet(value))
                    {
                        Console.WriteLine("Enter street: ");
                        value = Console.ReadLine();
                    }
                    street = value;
                }
            }

            public string City
            {
                get { return city; }
                set
                {
                    while (!IsValidCity(value))
                    {
                        Console.WriteLine("Enter city: ");
                        value = Console.ReadLine();
                    }
                    city = value;
                }
            }

            public string Country
            {
                get { return country; }
                set
                {
                    while (!IsValidCountry(value))
                    {
                        Console.WriteLine("Enter country: ");
                        value = Console.ReadLine();
                    }
                    country = value;
                }
            }

            public int BuildingNum
            {
                get { return buildingNum; }
                set
                {
                    while (!IsValidBuildingNum(value))
                    {
                        Console.WriteLine("Enter building number: ");
                        while (!int.TryParse(Console.ReadLine(), out value))
                        {
                            Console.WriteLine("Invalid input. Enter a valid building number: ");
                        }
                    }
                    buildingNum = value;
                }
            }

            public string PrintAdress()
            {
                return $"The adress is: Country: {Country}, City: {City}, Street: {Street}, Building number is: {BuildingNum}";
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Adress other = (Adress)obj;
                return Street == other.Street && City == other.City && Country == other.Country && BuildingNum == other.BuildingNum;
            }

            public override int GetHashCode()
            {
                return Tuple.Create(Street, City, Country, BuildingNum).GetHashCode();
            }
        }
    }

