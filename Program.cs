using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace rngnumbagame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int number;
            int min = 1;
            int max = 100;
            int guess;
            int guessess;
            string response;
            bool playagain = true;
            int tries = 5;
            string response2;
            string reset;
            

            

            while (playagain)
            {
                guess = 0;
                guessess = 0;
                number = random.Next(min + 1, max + 1);
                tries = 5;
                
                Console.WriteLine("Benvenutti! il rng game numbah! pick! one between 1 - 100");
                while (guess != number) { 
                    while (tries != 0)
                {
                    
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess < number) 
                    {
                            
                        Console.WriteLine("you too low");
                        guessess++;
                        tries--;
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("you too high");
                        guessess++;
                        tries--;
                    }
                    else
                    {
                        Console.WriteLine("grats!!");
                        Console.WriteLine("le pegaste en: " + guessess);
                        Console.WriteLine("con: "+ tries + "vidas");
                        Console.WriteLine("play again?");
                        Console.WriteLine("Y/N?");
                       response = Console.ReadLine();
                        response.ToUpper();
                        if (response == "Y")
                        {
                            playagain = true;
                        }
                        else if (response == "N")
                        {
                            Console.WriteLine("BYE BYE");
                            playagain = false;
                        }
                        else 
                                {
                            Console.WriteLine("QUE HICISTEEEE");
                        }
                    }
                        if (tries == 0)
                        {
                            Console.WriteLine("te qedaste sin intentos wachen!");
                            Console.WriteLine("jugar de nuevo? Y/N");
                            Console.WriteLine(number);
                            response2 = Console.ReadLine();
                            response2.ToUpper();
                            if (response2 == "Y")
                            {
                                tries ++;
                                tries++;
                                tries++;
                                tries++;
                                tries++;
                                playagain = true;   
                            }
                             else if (response2 == "N") 
                                        {
                                playagain = false;
                                tries = 0;
                                
                            }
                            
                        }
                }


                }



            }
            Console.WriteLine("si te qedas sin intentos y qeres jugar de nuevo apreta Y");
            reset = Console.ReadLine();
            if (reset=="Y") 
            {
                guess = 0;
                guessess = 0;
                number = random.Next(min + 1, max + 1);
                tries = 5;

            }
            else 
            {
                Console.WriteLine("BYE BYE");
                Console.ReadKey();
            }

            
            
            
            

                
        }
    }
}
