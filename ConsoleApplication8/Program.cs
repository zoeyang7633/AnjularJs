using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Replace(" ",string.Empty);
            char[] characters = input.ToCharArray();
            bool yes = true;
            for(int i=0;i<characters.Length/2;i++)
            {
                if (i == characters.Length / 2)
                {
                    
                    break;
                }
                if (characters[i].ToString().ToUpper() != characters[characters.Length - 1 - i].ToString().ToUpper())
                {
                    yes = false;
                    break;
                }
            }
            Console.WriteLine(yes);

        }
    }
}
