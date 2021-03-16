using System;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Car #1 ");
            Car car01 = 
            new Car("Red","Toyota ");
            car01.fullgastank();
            car01.km();
            car01.remaininggasoline();


        }
    }
}
