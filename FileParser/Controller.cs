using System;
using System.IO;

namespace FileParser
{
    public class Controller
    {
        public int CountOfSubStringMatches { get; private set; }

        public string[] Lines { get; private set; }

        public int LineNumber { get; private set; }

        public string SerchingSubString { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="lineNumber">Строка для подсчёта</param>
        public Controller(string path, string lineNumber)
        {
            try
            {
                this.LineNumber = Convert.ToInt32(lineNumber);
                Lines = File.ReadAllLines(path);
                Console.Write("Enter Substring to find: ");
                this.SerchingSubString = Console.ReadLine();
                this.CountOfSubStringMatches = StaticParser.FindSubString(path, this.LineNumber, SerchingSubString, Lines);
            }
            catch (Exception ex)
            {

                throw new Exception("Аргументы введены неверно пожалуйста повторите попытку " + ex.Message);
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="serchingSubString"></param>
        /// <param name="replaceSubString"></param>
        public Controller(string path, string serchingSubString, string replaceSubString)
        {
            try
            {

                this.LineNumber = Convert.ToInt32(Console.ReadLine());
                Lines = File.ReadAllLines(path);
                this.SerchingSubString = serchingSubString;
                replaceSubString = StaticParser.FindAndReplaceSubString(path, this.LineNumber, SerchingSubString, ReplaceSubString, Lines);
                Lines[this.LineNumber - 1] = replaceSubString;
                File.WriteAllLines(Environment.CurrentDirectory + @"\txtfiles\1.txt", Lines);
            }
            catch (Exception ex)
            {

                throw new Exception("Аргументы введены неверно пожалуйста повторите попытку " + ex.Message);
            }

        }

        public void DisplayHowMuchEntracne()
        {
            Console.WriteLine($"In line {Lines[LineNumber - 1]} {SerchingSubString} entrance {CountOfSubStringMatches} times");
        }

        public void DisplayAllLines()
        {
            for (int i = 0; i < Lines.Length; i++)
            {
                Console.WriteLine(Lines[i]);
            }
        }

        public void DisplayLine(int number)
        {
            try
            {
                Console.WriteLine(Lines[number - 1]);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
