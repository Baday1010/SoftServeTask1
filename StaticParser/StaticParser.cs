using System;

namespace Parser
{
    public static class StaticParser
    {
        public static int FindSubString(int lineNumber, string subString, string[] lines)
        {
            try
            {
                return System.Text.RegularExpressions.Regex.Matches(lines[lineNumber - 1], subString).Count;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Parameters can't be null.");
                return 0;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Parameters enter incorrectly please try again.");
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception caught.", ex);
            }

        }

        public static string FindAndReplaceSubString(int lineNumber, string subStringToSearch, string subStringToReplace, string[] lines)
        {
            try
            {
                return lines[lineNumber - 1].Replace(subStringToSearch, subStringToReplace);
            }
            catch (Exception)
            {

                Console.WriteLine($"An error was found");
                return String.Empty;
            }
        }
    }
}
