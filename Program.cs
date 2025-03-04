namespace Topic_5___Assignment_Prat_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string planet;
            double weight, veunsGravity, marsGravity, jupiterGravity, saturnGravity, uranusGravity, neptuneGravity;

           
            veunsGravity = 0.78;
            marsGravity = 0.39;
            jupiterGravity = 2.65;
            saturnGravity = 1.17;
            uranusGravity = 1.05;
            neptuneGravity = 1.23;

            Console.Write("Please eneter you currnet earth wight: ");
            double.TryParse(Console.ReadLine(),out weight);
            Console.WriteLine();
            Console.Write("I have information for the following planets:\r\n1. Venus 2. Mars 3. Jupiter\r\n4. Saturn 5. Uranus 6. Neptune");
            Console.WriteLine();
            Console.Write("Which planet are you visiting ? ");
 
            planet = Console.ReadLine();

            if (planet == "venus".ToLower() || planet == "1")
            {
                Console.WriteLine("Your wight would be " + (weight * veunsGravity) + " pounds on that planet.");
            }
            else if (planet == "mars".ToLower() || planet == "2")
            {
                Console.WriteLine("Your wight would be " + (weight * marsGravity) + " pounds on that planet.");
            }
            else if (planet == "Jupiter".ToLower() || planet == "3")
            {
                Console.WriteLine("Your wight would be " + (weight * jupiterGravity) + " pounds on that planet.");
            }
            else if (planet == "Saturn".ToLower() || planet == "4")
            {
                Console.WriteLine("Your wight would be " + (weight * saturnGravity) + " pounds on that planet.");
            }
            else if (planet == "Uranus".ToLower() || planet == "5")
            {
                Console.WriteLine("Your wight would be " + (weight * uranusGravity) + " pounds on that planet.");
            }
            else if (planet == "Neptune".ToLower() || planet == "6")
            {
                Console.WriteLine("Your wight would be " + (weight * neptuneGravity) + " pounds on that planet.");
            }
           

        }

    }
}
