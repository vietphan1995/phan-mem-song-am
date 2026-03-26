using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemSongAm
{
    internal class DoubleQuote
    {
        private const string OPEN = "open";
        private const string CLOSE = "close";

        private string _shape = "";
        public DoubleQuote(string input) 
        {
            if (input != null && !string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input))
            {
                if (input.Trim() != null && input == "\"")
                {
                    this._shape = OPEN;
                }
            }
            
        }

        public static string Trim(string input)
        {
            return input.Replace("\"", string.Empty);
        }
    }
}
