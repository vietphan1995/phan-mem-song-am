using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhanMemSongAm
{
    internal class NameDetector
    {
        //public NameDetector() { }

        public List<string> Detect(string message) 
        {
            var names = new List<string>();
            var elements = message.Split(' ');
            for (int i =0; i< elements.Length; i++)
            {
                if (elements[i].FirstOrDefault() != null && char.IsUpper(elements[i].FirstOrDefault()))
                {
                    names.Add(elements[i]);
                }
            }

            for (int j =0; j <names.Count; j++)
            {
                Console.WriteLine($"name: {names[j]}");
            }

            return names;
        }
    }
}
