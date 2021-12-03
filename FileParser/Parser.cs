using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileParser
{
    public class Parser
    {
        public string Path { get; }

        public string[] lines { get; private set; }

        public string SerchingSubString { get; }

        public int CounterOfEntrance { get; set; }

        public int LineToCheck { get; private set; }

        public Parser(string Path, string SerchingSubString, string a)
        {
            this.Path = Path;
            this.SerchingSubString = SerchingSubString;
            lines = File.ReadAllLines(Path);
        }
        /// <summary>
        /// (путь к файлу) (строка для подсчёта)  
        /// </summary>
        /// <param name="Path">Path to File</param>
        /// <param name="lineToChech">Find String</param>
        public Parser(string Path, string lineToChech)
        {
            try
            {
                this.Path = Path;
                this.LineToCheck = Convert.ToInt32(LineToCheck);
                lines = File.ReadAllLines(Path);
                Console.Write("Enter Substring to find: ");
                this.SerchingSubString = Console.ReadLine();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading from {0}. Message = {1}", this.Path, ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            

        }

        public int FindSubString(int lineNumber)
        {
            try
            {
                this.LineToCheck = lineNumber;
                return Regex.Matches(lines[lineNumber - 1], SerchingSubString).Count;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void DisplayHowMuchEntracne()
        {
            Console.WriteLine($"In line {lines[LineToCheck - 1]} {SerchingSubString} entrance {CounterOfEntrance} times");
        }

        public void DisplayAllLines()
        {
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }

        public void DisplayLine(int number)
        {
            try
            {
                Console.WriteLine(lines[number - 1]);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
    }
}
