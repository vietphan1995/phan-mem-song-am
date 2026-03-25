using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemSongAm
{
    public class BagOfPositive
    {


        private Dictionary<string, int> _keyWords = new Dictionary<string, int>() 
        {
            { "vui", 1 },
            { "cuoi", 2 },
            { "dong y", 3 },
            { "chap nhan", 4 }
        };

        public Dictionary<string, int> GetMatchedWords(string message)
        {
            var matchedWords = new Dictionary<string, int>();

            foreach (var keyWord in this._keyWords)
            {
                if (message.Contains(keyWord.Key))
                {
                    matchedWords.Add(keyWord.Key, keyWord.Value);
                }
            }

            return matchedWords;
        }

        public int GetPoint(string message)
        {
            var point = 0;

            var matchedWords = this.GetMatchedWords(message);

            foreach (var keyWord in matchedWords)
            {
                point += matchedWords[keyWord.Key];
            }

            return point;
        }
    }
}
