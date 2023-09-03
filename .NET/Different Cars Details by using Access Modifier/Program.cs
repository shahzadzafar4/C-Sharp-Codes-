using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Access_Modifier
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter any name from the following to check the car informations as per written");
            Console.WriteLine("Ferrari: ");
            Console.WriteLine("Mercedes: ");
            Console.WriteLine("Loyota: ");
            Console.WriteLine("Lambo: ");
            Console.WriteLine("Tesla: ");
            string name = Console.ReadLine();


            if (name == "ferrari")
            {
                Car myCar = new Car();
                myCar.name = "Ferrari";
                myCar.description = "Best Car in the World";
                myCar.type = "Automatic";
                myCar.color = "Black";
                myCar.price = "$ 3M";
                myCar.PrintCarInformations();
            }

            if (name == "Ferrari")
            {
                Car myCar = new Car();
                myCar.name = "Ferrari";
                myCar.description = "Best Car in the World";
                myCar.type = "Manual";
                myCar.color = "White";
                myCar.price = "$ 50K";
                myCar.PrintCarInformations();
            }

            if (name == "Toyota")
            {
                Car myCar = new Car();
                myCar.name = "Toyota";
                myCar.description = "Cheaper car";
                myCar.type = "Automatic";
                myCar.color = "Black";
                myCar.price = "$ 50k";
                myCar.PrintCarInformations();
            }
            if (name == "toyota")
            {
                Car myCar = new Car();
                myCar.name = "Toyota";
                myCar.description = "Cheaper car";
                myCar.type = "Automatic";
                myCar.color = "Black";
                myCar.price = "$ 50k";
                myCar.PrintCarInformations();
            }

            if (name == "Lambo")
            {
                Car myCar = new Car();
                myCar.name = "Lambo";
                myCar.description = "#1 Car in the World";
                myCar.type = "Automatic";
                myCar.color = "Yellow";
                myCar.price = "$ 5M";
                myCar.PrintCarInformations();
            }

            if (name == "lambo")
            {
                Car myCar = new Car();
                myCar.name = "Lambo";
                myCar.description = "#1 Car in the World";
                myCar.type = "Automatic";
                myCar.color = "Yellow";
                myCar.price = "$ 5M";
                myCar.PrintCarInformations();
            }
            if (name == "Mercedes")
            {
                Car myCar = new Car();
                myCar.name = "Mercedes";
                myCar.description = "Luxury";
                myCar.type = "Automatic";
                myCar.color = "Black";
                myCar.price = "$ 1M";
                myCar.PrintCarInformations();
            }
            if (name == "mercedes")
            {
                Car myCar = new Car();
                myCar.name = "Mercedes";
                myCar.description = "Luxury";
                myCar.type = "Automatic";
                myCar.color = "Black";
                myCar.price = "$ 1M";
                myCar.PrintCarInformations();
            }

            if (name == "Tesla")
            {
                Car myCar = new Car();
                myCar.name = "Tesla";
                myCar.description = "Electric";
                myCar.type = "Automatic";
                myCar.color = "Black";
                myCar.price = "$ 10M";
                myCar.PrintCarInformations();
            }

            if (name == "tesla")
            {
                Car myCar = new Car();
                myCar.name = "Tesla";
                myCar.description = "Electric";
                myCar.type = "Automatic";
                myCar.color = "Black";
                myCar.price = "$ 10M";
                myCar.PrintCarInformations();
            }

            else
            {
                Console.WriteLine("Input Error");
                Console.ReadLine();
            }
           
        }
        class Car
        {
            public string name;
            public string description;
            public string type;
            public string color;
            public string price;

            public void PrintCarInformations()
            {
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Descruptions:" + description);
                Console.WriteLine("Type:" + type);
                Console.WriteLine("Color:" + color);
                Console.WriteLine("Price:" + price);
                Console.ReadLine();
            }


        }


    }
}
