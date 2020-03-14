using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp3;

namespace WindowsFormsApp3
{
    class CSVReader
    {
        private string fileName;
        private TextWriter writer;
        public CSVReader(string fileName, TextWriter writer)
        {
            this.fileName = fileName;
            this.writer = writer;
        }

        private string[] GetAllLines()
        {
            try 
            {
                return File.ReadAllLines(fileName);
            }
            catch (Exception e) 
            {
                writer.WriteLine("Exception while working with file: " + e.Message);
                Console.WriteLine(e.Message);
                return null;
            }
        }

        /// <summary>
        /// Парсит исходную строку из csv файла.
        /// </summary>
        /// <param name="line"></param>
        /// <returns>Массив данных из исходной строки</returns>
        private string[] GetLineData(string line)
        {
            return line.Split(';');
        }

        /// <summary>
        /// Конвертирует сроку из csv файла в эклепляр класса Hero.
        /// </summary>
        /// <param name="line"></param>
        /// <returns>Заполненный экземпляр класса Hero</returns>
        private Hero ConvertLineToHero(string line)
        {
            string[] data = GetLineData(line);
            Hero hero = new Hero();
            hero.Name = data[0];
            hero.DamagePerSecond = data[1] == string.Empty ? -1 : double.Parse(data[1].Replace('.', ','));
            hero.HeadshotDPS = data[2] == string.Empty ? -1 : double.Parse(data[2].Replace('.', ','));
            hero.SingleShot = data[3] == string.Empty ? -1 : double.Parse(data[3].Replace('.', ','));
            hero.Life = data[4] == string.Empty ? -1 : double.Parse(data[4].Replace('.', ','));
            hero.Reload = data[5] == string.Empty ? -1 : data[5] == "infinity" ? -10 : double.Parse(data[5].Replace('.', ','));

            return hero;
        }

        /// <summary>
        /// Конвертирует файл в список героев.
        /// </summary>
        /// <returns></returns>
        public List<Hero> ConvertFileToHeroesList()
        {
            string[] lines = GetAllLines();
            List<Hero> heroes = new List<Hero> { };
            for (int i = 1; i < lines.Length; i++)
            {
                heroes.Add(ConvertLineToHero(lines[i]));
            }
            return heroes;
        }

        /// <summary>
        /// Возвращает заголовки указанного файла.
        /// </summary>
        /// <returns>Массив заголовков коллон</returns>
        public string[] GetHeaders()
        {
            return GetLineData(GetAllLines()[0]);
        }

        /// <summary>
        /// Метод считывает всю иеформацию из CSV файла поэлементно и возвращает двумерный массив со всей информацией.
        /// </summary>
        /// <returns></returns>
        public string[,] ReadFile()
        {
            string[] lines = GetAllLines();
            if (lines is null)
            {
                writer.WriteLine("Can't read this file");
                return null;
            }
            string[,] data = new string[lines.Length, GetLineData(lines[0]).Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] lineData = GetLineData(lines[i]);
                for (int j = 0; j < lineData.Length; j++)
                {
                    data[i, j] = lineData[j];
                }
            }
            return data;
        }
    }
}
