namespace Topic_5_assignment_part_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double earthWeight, planetWeight;
            string visitingPlanet;

            Console.WriteLine("Please enter your current earth weight: ");
            double.TryParse(Console.ReadLine(), out earthWeight);
            Console.WriteLine(" ");
            Console.WriteLine("I have information for the following planets:");
            Console.WriteLine("1. Venus");
            Console.WriteLine("2. Mars");
            Console.WriteLine("3. Jupiter");
            Console.WriteLine("4. Saturn");
            Console.WriteLine("5. Uranus");
            Console.WriteLine("6. Neptune");
            Console.WriteLine("Please enter the name of the planet you are visiting");
            visitingPlanet = Console.ReadLine();
            

        }
    }
}
