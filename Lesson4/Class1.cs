using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{
    class Car
    {
        int doors;
        int enginePower;
        string model;
        //Методы
        //Void не возвращает значения после завершения метода
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        //Метод с Int возвращает значения (целочисленные)
        public int Method2()
        {
            var myInt = 10;
            return myInt;
        }

        //Метод с аргументами (аргумент указывает на тип переменной для возврата, число int приобразуется в строку string)
        public string Method3(int count)
        {
            return count.ToString();
        }
    }

    struct CarStruct
    {
        int doors;
        int enginePower;
        string model;
    }
}