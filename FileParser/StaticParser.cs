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
        public static int FindSubString(string path, int lineNumber, string subString, string[] lines)
        {
            try
            {
                return Regex.Matches(lines[lineNumber - 1], subString).Count;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static string FindAndReplaceSubString(string path, int lineNumber, string subStringToSearch,
            string subStringToReplace, string[] lines)
        {
            try
            {
                return lines[lineNumber - 1].Replace(subStringToSearch, subStringToReplace);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
