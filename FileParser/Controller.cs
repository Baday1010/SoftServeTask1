using System;
using System.IO;

namespace FileParser
{
    public class Controller
    {
        private int CountOfSubStringMatches { get; set; }

        private string[] Lines { get; set; }

        private int LineNumber { get; set; }

        private string SerchingSubString { get; set; }

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
                this.CountOfSubStringMatches = StaticParser.FindSubString(this.LineNumber, SerchingSubString, Lines);
            }
            catch (Exception ex)
            {

                throw new Exception("Parametrs entered incorrectly please try again. " + ex.Message);
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
                Lines[this.LineNumber - 1] = StaticParser.FindAndReplaceSubString(this.LineNumber, SerchingSubString, replaceSubString, Lines);
                File.WriteAllLines(Environment.CurrentDirectory + @"\txtfiles\1.txt", Lines);
            }
            catch (Exception ex)
            {

                throw new Exception("Parametrs entered incorrectly please try again. " + ex.Message);
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
