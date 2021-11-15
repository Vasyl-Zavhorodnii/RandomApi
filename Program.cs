using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  
    internal class Program
    {
        public static bool IsAlpha(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z]+$");
            // rasobratsa? think is through 
        }
        static string Accum(string s)
        {
            if (IsAlpha(s) == false)
            {
                Console.WriteLine("Please, enter only A-Z,a-z letters"); return "wewe";
            }
            else
            {
                string b = "";

                for (int i = 0; i < s.Length; i++)
                {
                   // for (int j = 0; j < i; j++)
                   // { a += s[i]; } its my solution
                  
                   string  a = new string(s[i],i +1);//it is not my solution, it is solution of RUSLAN.ToAction(VSTAV))
                    b += s[i] + a + "-";
                    // a = ""; //its my solution
                }
                string result = b.Trim('-');
                return result;
            }

        }

        static void Main(string[] args)
        {
           
            String s = Console.ReadLine();
            String a = Accum(s);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
