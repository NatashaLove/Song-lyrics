using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nlove_homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            // clear the console
            Console.Clear();

            //display the name of the song and group
            Console.WriteLine("                                 NIRVANA");
            Console.WriteLine("                 *****************************************");
            Console.WriteLine("                   Where Did You Sleep Last Night ?");
            Console.WriteLine("                       (originally by Lead Belly)" + "\n");

            Console.WriteLine("********************************************************");

            // wait for user to respond
            Console.WriteLine("Press any key to see the first 2 lines:" + "\n");
            Console.ReadKey();

            //display the first 2 lines
            Console.WriteLine(" My girl, my girl, don't lie to me");
            Console.WriteLine(" Tell me where did you sleep last night" + "\n");

            // wait for user to respond
            Console.WriteLine("Press any key to see the girl's reply:" + "\n");
            Console.ReadKey();
        
            //display the reply
            Console.WriteLine(" In the pines, in the pines");
            Console.WriteLine(" Where the sun don't ever shine");
            Console.WriteLine(" I would shiver the whole night through..." + "\n");

            // wait for user to respond
            Console.WriteLine("Press any key to exit.");
            Console.WriteLine("********************************************************");
            Console.ReadKey();

        }

    }
}
