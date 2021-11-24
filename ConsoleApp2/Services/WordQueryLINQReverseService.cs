using ConsoleApp2.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public class WordQueryLINQReverseService : IWordReverseService
    {
        private readonly IWordReverseService _wordReverseService;
        public WordQueryLINQReverseService(IWordReverseService wordReverseService)
        {
            _wordReverseService = wordReverseService;
        }
        public string Reverse(string incoming)
        {
            return _wordReverseService.Reverse(incoming); 
        }


        public string Reverse2(string incoming)
        {
            throw new NotImplementedException();
        }
    }
}
