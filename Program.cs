namespace Guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Geben sie eine Zahl zwischen 1 und 100 ein");
            double zahl = Convert.ToDouble(Console.ReadLine());
            Random rnd = new Random();
            double zahl1 = new Random().Next(1, 100);

            if (zahl >= 1 && zahl <= 100)
            {
                while (zahl != zahl1)
                {
                    if (zahl > zahl1)
                    {
                        
                        Console.WriteLine("Die gesuchte Zahl ist kleiner");



                    }
                    else if (zahl < zahl1)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist grösser");
                    };


                    Console.WriteLine("Geben sie erneut eine Zahl zwischen 1 und 100 ein");
                    zahl = Convert.ToDouble(Console.ReadLine());


                    if (zahl < 1 || zahl > 100)
                    {



                        Console.WriteLine("Falsche Eingabe, bitte geben sie eine neue Zahl ein");
                        zahl1 = Convert.ToDouble(Console.ReadLine());
                    };
                };
            };
            if (zahl == zahl1)
            {
                Console.WriteLine("Sie haben die gesuchte Zahl erraten");

            };

        }
    }
}

