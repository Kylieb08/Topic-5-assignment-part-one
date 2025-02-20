using System.Diagnostics.CodeAnalysis;

namespace Topic_5_assignment_part_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double earthWeight;
            string visitingPlanet;
            bool done = false;

            Console.WriteLine("Please enter your current earth weight in pounds: ");
            double.TryParse(Console.ReadLine(), out earthWeight);
            Console.WriteLine(" ");
            Console.WriteLine("I have information for the following planets:");
            Console.WriteLine("1. Venus");
            Console.WriteLine("2. Mars");
            Console.WriteLine("3. Jupiter");
            Console.WriteLine("4. Saturn");
            Console.WriteLine("5. Uranus");
            Console.WriteLine("6. Neptune");
            Console.WriteLine(" ");
            

            //ask about invalid input
            while (!done)
            {
                done = true;
                Console.WriteLine("Please enter the name of the planet you are visiting: ");
                visitingPlanet = Console.ReadLine();

                if (visitingPlanet.ToLower() == "venus")
                {
                    Console.WriteLine("Your weight would be " + (earthWeight * 0.78) + " pounds on Venus");
                }
                else if (visitingPlanet.ToLower() == "mars")
                {
                    Console.WriteLine("Your weight would be " + (earthWeight * 0.39) + " pounds on Mars");
                }
                else if (visitingPlanet.ToLower() == "jupiter")
                {
                    Console.WriteLine("Your weight would be " + (earthWeight * 2.65) + " pounds on Jupiter");
                }
                else if (visitingPlanet.ToLower() == "saturn")
                {
                    Console.WriteLine("Your weight would be " + (earthWeight * 1.17) + " pounds on Saturn");
                }
                else if (visitingPlanet.ToLower() == "uranus")
                {
                    Console.WriteLine("Your weight would be " + (earthWeight * 1.05) + " pounds on Uranus");
                }
                else if (visitingPlanet.ToLower() == "neptune")
                {
                    Console.WriteLine("Your weight would be " + (earthWeight * 1.23) + " pounds on Neptune");
                }
                else
                {
                    Console.WriteLine("Not a planet");
                    done = false;
                }
            }
        }
    }
}
