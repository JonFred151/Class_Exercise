using System;
namespace Classes_Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cars = new Car();

            cars.Make = "Ford";
            cars.Model = "F150";
            cars.year = 2016;

            Console.WriteLine($"My truck is a {cars.Make} {cars.Model}! it's year is {cars.year}! ");

        }
    }
}