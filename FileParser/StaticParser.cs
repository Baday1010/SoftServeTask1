using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileParser
{
    public static class StaticParser
    {
        public static int FindSubString(int lineNumber, string subString, string[] lines)
        {
            try
            {
                return Regex.Matches(lines[lineNumber - 1], subString).Count;
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Parameters can't be null. " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("Parameters enter incorrectly " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("{0} Exception caught.", ex);
            }

        }

        public static string FindAndReplaceSubString(int lineNumber, string subStringToSearch, string subStringToReplace, string[] lines)
        {
            try
            {
                return lines[lineNumber - 1].Replace(subStringToSearch, subStringToReplace);
            }
            catch (Exception ex)
            {

                throw new Exception($"{ex.Message} An error was found");
            }
        }
    }
}
