using System;

namespace backPack
{
    class MainClass
    {
        public static void Main(string[] args)


        {
            while (true) 
            {
                    Console.WriteLine("Välkommen till ryggsäcken! " + "Välj i menyn:");
                Console.WriteLine("\t[1]Lägg till ett föremål i ryggsäcken:");
                Console.WriteLine("\t[2]Visa innehåll i ryggsäcken: ");
                Console.WriteLine("\t[3]Rensa innehållet: ");
                Console.WriteLine("\t[4] sök innehåll:");
                Console.WriteLine("\t[5] avsluta");
                //string ryggFylla = Console.ReadLine();
                string[] ryggFylla = new string[5];

                ryggFylla[0] = "banan";
                ryggFylla[1] = "äpple";
                ryggFylla[2] = "kanelbulle";
                ryggFylla[3] = "pasta";
                ryggFylla[4] = "lasagne";
                int menyVal = Convert.ToInt32(Console.ReadLine());
                string ryggFylla = Console.ReadLine();

                switch (menyVal)
                {
                    case 1:
                        Console.WriteLine("\t[1]Lägg till ett föremål i ryggsäcken:");


                        break;


                    case 2:
                        Console.WriteLine("\t[2]Visa innehåll i ryggsäcken: ");
                    
                        break;

                    case 3:
                        Console.WriteLine("\t[3]Rensa innehållet: " + ryggFylla);


                        break;

                    case 4:
                        Console.WriteLine("\t[4] sök innehåll:");


                        break;

                    case 5:
                        Console.WriteLine("\t[5] avsluta");

                        break;
                }
             }
        }
    }
}
