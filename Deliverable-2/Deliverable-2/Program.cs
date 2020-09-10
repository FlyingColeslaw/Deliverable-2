using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int numberOfFlips = 0;
            int correctCounter = 0;
            Random coinflip = new Random();

            string headsOrTailsGuess;

            Console.Write("Guess which will have more: heads or tails?: ");
            headsOrTailsGuess = Console.ReadLine();



            Console.Write("How many times shall we flip a coin?: ");
            numberOfFlips = Convert.ToInt32(Console.ReadLine());





            for (int i = 0; i < numberOfFlips; i++)
            {
                int flip = coinflip.Next(1, 3);
                if (flip == 1)
                {
                    

                    if (headsOrTailsGuess == "heads")
                    {
                        correctCounter++;
                            }
                    Console.WriteLine("heads");
                }
                else
                {
                    if (headsOrTailsGuess == "tails")
                        
                    {
                        correctCounter++;
                            }
                    Console.WriteLine("tails");


                }
            }


            float sum = (float)correctCounter / numberOfFlips * 100;
            

            if (headsOrTailsGuess == "heads")
                    Console.WriteLine("Your guess, " + headsOrTailsGuess
               + ", came up " + correctCounter + " time(s). That's " + sum + "%.");


                if (headsOrTailsGuess == "tails")
                    Console.WriteLine("Your guess, " + headsOrTailsGuess
               + ", came up " + correctCounter + " time(s).That's " + sum + "%.");
                 Console.ReadKey();


                
        
        }
    }
}
