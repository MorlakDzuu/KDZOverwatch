using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVReader reader = new CSVReader("Overwatch.csv", Console.Out);
            List<Hero> heroes = reader.ConvertFileToHeroesList();
            heroes.ForEach(x => Console.WriteLine(x.ToString()));
            Console.ReadLine();
            
        }
    }
}
