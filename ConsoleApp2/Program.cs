using ConsoleApp2.Contract;
using ConsoleApp2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void MyMethod(IWordReverseService service, string input)
        {

            string reversed = service.Reverse(input);
            Console.WriteLine("reversed:");

            Console.WriteLine(reversed);

        }
        
        static void Main(string[] args)
        {


            IWordReverseService i = new WordMethodLINQReverseService();
            IWordReverseService j = new WordQueryLINQReverseService(i);
            IWordReverseService k = new WordQueryLINQReverseService(j);
            // IWordReverseService i = new ldfkgjkdjgbngdskj();
            MyMethod(i, " reversed shit i know come to watch the rain it falling down");
            MyMethod(j, " reversed shit i know come to watch the rain it falling down");
            MyMethod(k, " reversed shit i know come to watch the rain it falling down");



            Console.ReadLine();
        }
    }
}
