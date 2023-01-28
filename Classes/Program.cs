using System.Xml.Schema;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();// constructor special member method help us create new instance of the Cas class
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2013;

            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2016

            };
            var chevy = new Car("Chevy", "Impala", 2000);
            var carList = new List<Car>() { myCar, mazda, chevy };
            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
             
        }
    }
}
