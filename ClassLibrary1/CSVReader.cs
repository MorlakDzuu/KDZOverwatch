using System;
using System.Collections.Generic;
using System.IO;

namespace ClassLibrary1
{
    public class CSVReader
    {
        private string fileName;
        private TextWriter writer;
        public CSVReader(string fileName, TextWriter writer)
        {
            if (!File.Exists(fileName))
                throw new Exception("There is no file with such name");
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
            string[] data =  line.Split(';');
            for (int i = 0; i < data.Length; i++)
                if (data[i] == String.Empty)
                    data[i] = "0";
            return data;
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
            try
            {
                hero.Name = data[0];
                hero.DamagePerSecond = data[1] == string.Empty ? -1 : double.Parse(data[1].Replace('.', ','));
                hero.HeadshotDPS = data[2] == string.Empty ? -1 : double.Parse(data[2].Replace('.', ','));
                hero.SingleShot = data[3] == string.Empty ? -1 : double.Parse(data[3].Replace('.', ','));
                hero.Life = data[4] == string.Empty ? -1 : double.Parse(data[4].Replace('.', ','));
                hero.Reload =  data[5] == "infinity" ? "infinity" : double.Parse(data[5].Replace('.', ',')).ToString();
            } catch (Exception)
            {
                return null;
            }

            return hero;
        }

        /// <summary>
        /// Конвертирует файл в список героев.
        /// </summary>
        /// <returns></returns>
        public List<Hero> ConvertFileToHeroesList()
        {
            string[] lines = GetAllLines();
            Hero hero;
            List<Hero> heroes = new List<Hero> { };
            for (int i = 1; i < lines.Length; i++)
            {
                hero = ConvertLineToHero(lines[i]);
                if (hero != null)
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
        public string[][] ReadFile()
        {
            string[] lines = GetAllLines();
            if (lines is null)
            {
                writer.WriteLine("Can't read this file");
                return null;
            }
            string[][] data = new string[lines.Length - 1][];
            for (int i = 1; i < lines.Length; i++)
            {
                data[i-1] = GetLineData(lines[i]);
            }
            return data;
        }

        public void RewriteFile(string[][] data)
        {
            string resultText = String.Empty;
            string[] headers = GetHeaders();
            foreach (string header in headers)
                resultText += header + ';';
            resultText = resultText.Substring(0, resultText.Length - 1);
            resultText += Environment.NewLine;
            foreach (string[] line in data)
            {
                foreach (string elem in line)
                    resultText += elem + ';';
                resultText = resultText.Substring(0, resultText.Length - 1);
                resultText += Environment.NewLine;
            }
            File.WriteAllText(fileName, resultText);
        }
    }
}
