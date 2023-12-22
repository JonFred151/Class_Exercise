using System;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Choice;
           


            do
            {
                var Lot = new Car(); 
                Console.WriteLine("Choose a selection. \n1: Make a car \n2: How many car in the lot. \n3:Exit");
                if (int.TryParse(Console.ReadLine(), out Choice))
                {
                    switch (Choice)
                    {
                        // make a car
                        case 1: 
                            Console.Clear();
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
                            CarLot.NumberOfCars++;
                            Console.WriteLine($"Your Car is a {Lot.Make} and is a {Lot.Model} from the year {Lot.year}");
                            Lot.MakeEngineNoise(Lot.EngineNoise);
                            Lot.MakeHonkNoise(Lot.HonkNoise);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine($"Number of car in lot is {CarLot.NumberOfCars}");
                            Console.ReadKey();
                            Console.Clear();   
                            break;
                         case 3:
                            Console.Clear();
                            Console.WriteLine("Exiting Program");
                            break;
                        default:
                            Console.Clear() ;
                            Console.WriteLine("Invalid Choice. Please select the given option!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input try again!");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (Choice != 3);






            







        }
    }
}