using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();

            teacher.salary = 600;

            Car car = new Car(8,90);
            Console.WriteLine(car.Drive(5));
            Console.WriteLine(car.globalkm);
            Console.WriteLine(car.localkm);
            Console.WriteLine(car.currentFuel);
            Console.WriteLine(car.AddFuel(10));
            Console.ReadLine();
           
        }
    }
}
