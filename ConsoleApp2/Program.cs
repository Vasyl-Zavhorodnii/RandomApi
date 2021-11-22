using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона", "Руслан", "Встав", "Яйця"};

            var selectedTeams = from t in teams 
                                where t.ToUpper().Length>=5 
                                orderby t  
                                select t; 

            foreach (string s in selectedTeams)
                Console.WriteLine(string.Join(",", s).Reverse().ToArray());
            Console.ReadLine();
        }
    }
}
