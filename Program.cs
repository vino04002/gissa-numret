using System;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rand = new Random(); //här så väljer den ett slumptal mellan 1-100
            int guess = 0;
            string welcome = "gissa ett nummer mellan 1-100";
            int num = rand.Next(1,100);
            Console.WriteLine(welcome);
            
 
            int i = 0;
            
            while(guess != num)
            {
                try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());

                        if (guess > num)
                            {
                                Console.WriteLine("för högt");
                            }
                        else
                            {
                                Console.WriteLine("för lågt");
                            } 
                    }

                catch
                    {
                        Console.WriteLine("det måste vara ett nummerr");
                        i--;
                    }  //här så beror det på vad man gissar. om man gissa högre så står att det blir högre och om midre så står det mindre tills du gissar rätt. 
                
                
                i++;
            }
            Console.WriteLine("det tog dig " + i + " försök");
            Console.ReadLine();
        }
    }
}