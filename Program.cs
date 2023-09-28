namespace NumbersGAMEE  
{
    internal class Program //Hany Alhabboby NET23
    {
        static void Main(string[] args)
        {
            RandomNumbers(); //här anropar vi metoden

        }

        public static void RandomNumbers()
        {
            Console.WriteLine("Vällkomen!");
            int attempts = 5; //Skapar antal försök som användaren har
            Random randoms = new Random(); // Skapa en randomare som slumpar fram ett tal
            int number = randoms.Next(1, 20); // Här ska talen slumpas mellan 1 och 20


            while (attempts > 0)
            {
                Console.WriteLine("Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök");
                Console.WriteLine("Du har " + attempts + " kvar");
                attempts--;

                int userInput = int.Parse(Console.ReadLine());


                if (userInput == number) // om användaren gissar rätt
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;
                }

                else if (userInput > number) // om användaren gissar högt

                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                }

                else if (userInput < number) // om användaren gissar lågt
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");

                }

                if (attempts == 0) // om alla försök tar slut
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");

                }


            }

        }

    }
}