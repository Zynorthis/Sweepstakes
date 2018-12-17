using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            string part1 = "\n Loading";
            string part2 = "\n Loading.";
            string part3 = "\n Loading..";
            string part4 = "\n Loading...";

            int i = 0;
            while (i < 10)
            {
                GUI.DisplaySuccess(part1);
                System.Threading.Thread.Sleep(500);
                GUI.DisplaySuccess(part2);
                System.Threading.Thread.Sleep(500);
                GUI.DisplaySuccess(part3);
                System.Threading.Thread.Sleep(500);
                GUI.DisplaySuccess(part4);
                System.Threading.Thread.Sleep(500);
                i++;
            }
            GUI.DisplaySuccess("Done!");
            Console.ReadKey();
        }
    }
}
