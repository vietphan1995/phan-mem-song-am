using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhanMemSongAm1
{
    internal class NameDetector
    {
        public NameDetector() { }

        public List<string> Detector(string message) 
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

            return names;
        }
    }
}
