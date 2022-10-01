using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var _struct = new CarStruct();

            car.Method1();

            Console.WriteLine(car.Method3(car.Method2()));
        }
    }
}

