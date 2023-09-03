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
            Car myCar = new Car();
            myCar.name = "Ferrari";
            myCar.description = "Best Car in the World";
            myCar.type = "Automatic";
            myCar.color = "Black";
            myCar.price = "$ 3M";
            myCar.PrintCarInformations();
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
