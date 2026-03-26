using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhanMemSongAm
{
    internal static class Name
    {
        private static char SPACE = ' ';
        private static List<string> NAMES = new List<string>() 
        {
            "Huy", "Gia Huy", "Hoang Gia Huy", "Nguyen Hoang Gia Huy"
        };

        // Huy, Gia Huy, Nguyen Hoang Gia Huy
        public static List<string> GetNames(string input) 
        {
            var names = new List<string>();

            var elements = input.Split(SPACE);
            
            for (int i =0; i< elements.Length; i++)
            {
                var currentElement = elements[i];

                if (currentElement.FirstOrDefault() != null && char.IsUpper(currentElement.FirstOrDefault()))
                {
                    names.Add(currentElement);
                }
            }

            

            return names;
        }
    }
}
