using System;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var Lot = new Car();

            Console.WriteLine("Enter your car Make, Model, Year of your car. \n");
            Lot.Make = Console.ReadLine();            
            Lot.Model = Console.ReadLine();            
            Lot.year = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("What sound does your Engine makes?");
            Lot.EngineNoise = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What Sound does your Horn make?");
            Lot.HonkNoise = Console.ReadLine();
            Console.Clear();


            Console.WriteLine($"Your Car is a {Lot.Make} and is a {Lot.Model} from the year {Lot.year}");
            Lot.MakeEngineNoise(Lot.EngineNoise);
            Lot.MakeHonkNoise(Lot.HonkNoise);







        }
    }
}