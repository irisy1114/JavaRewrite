using JavaRewrite.Animals;
using System;
using System.Collections.Generic;

namespace JavaRewrite
{
    public class Program
    {
        private static readonly DataContext dataContext = new DataContext("animals.txt");
        static void Main(string[] args)
        {
            var zoo = InitData();

            Console.WriteLine();
            PrintOut(zoo);
            Console.WriteLine();

            dataContext.ReadFromFile();
            Console.WriteLine();

            DataContext context = new DataContext("animals.txt");
            context.ReadFromFile();
            Console.WriteLine();

            Console.ReadLine();
        }

        private static List<ITalkable> InitData()
        {
            List<ITalkable> zoo = new List<ITalkable>();
            Console.Write("Please enter the type of animal you want to create (dog/cat): ");
            var animalType = Console.ReadLine().ToLower();     
            while(animalType != "dog" & animalType != "cat")
            {
                Console.Write("Please enter dog or cat: ");
                animalType = Console.ReadLine().ToLower();
            }
                
            if (animalType == "dog" | animalType == "cat")
            {
                Console.Write("Please enter the name of the animal: ");
                var name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.Write("Name can't be empty! Please enter again: ");
                    name = Console.ReadLine();
                }
                if(animalType == "dog")
                {
                    Console.Write("Is it friendly (y/n): ");
                    var result = Console.ReadLine().ToBool();
                    zoo.Add(new Dog(result, name));
                }
                else if (animalType == "cat")
                {
                    Console.Write("How many mousese killed: ");
                    var mousesKilled = Console.ReadLine();
                    int number;
                    while(!int.TryParse(mousesKilled, out number))
                    {
                        Console.Write("Please enter a number: ");
                        mousesKilled = Console.ReadLine();
                    }                         
                    zoo.Add(new Cat(number, name));


                }
            }
            return zoo;
        }



        public static void PrintOut(List<ITalkable> zoo)
        {
            List<string> data = new List<string>();
            foreach (ITalkable t in zoo)
            {
                Console.WriteLine(t.getName() + " says=" + t.talk());                
                data.Add(t.getName() + " | " + t.talk());                
            }
            dataContext.WriteToFile(data);
        }
    }
    static class Extensions
    {
        public static bool ToBool(this string input)
        {
            if (input.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else if (input.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            else
            {
                throw new Exception("The data is not in the correct format.");
            }
        }
    }
}
