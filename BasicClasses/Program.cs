using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    public string Make;
    public string Model;
    public int Year;
}
namespace BasicClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { Make = "Honda", Model = "Odyssey", Year = 2014 };
            Console.WriteLine("Car information:");
            Console.WriteLine("Make: " + car.Make);
            Console.WriteLine("Model:" + car.Model);
            Console.WriteLine("Year: " + car.Year);
            Console.ReadKey();
        }
    }
}
