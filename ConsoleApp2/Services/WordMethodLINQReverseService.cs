using ConsoleApp2.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    internal class WordMethodLINQReverseService : IWordReverseService
    {
        public string Reverse(string incoming)
        {
            var wordsarray = incoming.Split(' ');
            var mid = wordsarray.Select(word =>
            {
                return word.Length >= 5 ? new string(word.Reverse().ToArray()) : word;
            }
            );
            return string.Join(" ", mid);

        }
    }
}
