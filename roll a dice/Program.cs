using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace roll_a_dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rn,ern,pp=0,ap=0;
            Random random = new Random();
            for (int i = 1;i<=10;i++) 
            {
                Console.WriteLine(i+".   " + "press any key to roll the dice");
                Console.ReadKey();
                rn = random.Next(1,7);
                ern = random.Next(1,7);
                Console.WriteLine("you rolled:"+rn);
                Console.Write("ai is rolling."); System.Threading.Thread.Sleep(100); 
                Console.Write("."); System.Threading.Thread.Sleep(800);
                Console.Write("."); System.Threading.Thread.Sleep(600);
                Console.Write("."); System.Threading.Thread.Sleep(400);
                Console.Write("."); System.Threading.Thread.Sleep(200);
                Console.WriteLine("."); System.Threading.Thread.Sleep(100);
                
                Console.WriteLine("ai rolled :"+ern);
                Console.WriteLine("");
                if (rn > ern) { pp++; }
                else if (ern > rn) { ap++; }
            }
            if (pp > ap) { Console.WriteLine("You win !!!!!"); }
            else if (ap>pp) { Console.WriteLine("AI Wins !!!!!!"); }
            else { Console.WriteLine("Its draw lets do another round."); }
            Console.WriteLine("your point:"+pp);
            Console.WriteLine("Ai point is: "+ap);

            Console.ReadKey();
        }
    }
}

