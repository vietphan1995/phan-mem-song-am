using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemSongAm
{
    public static class BagOfPositive
    {

        private static Dictionary<string, int> _keyWords = new Dictionary<string, int>() 
        {
            { "vui", 1 },
            { "cuoi", 2 },
            { "dong y", 3 },
            { "chap nhan", 4 },
            { "ve nha", 5 },
            { "duoc", 6 },
            { "tan duong", 7 },
            { "dung buon nua", 8 }
        };

        public static Dictionary<string, int> GetMatchedWords(string message)
        {
            var matchedWords = new Dictionary<string, int>();

            foreach (var keyWord in _keyWords)
            {
                if (message.Contains(keyWord.Key))
                {
                    matchedWords.Add(keyWord.Key, keyWord.Value);
                }
            }

            return matchedWords;
        }

        public static int GetPoint(string message)
        {
            var point = 0;

            var matchedWords = GetMatchedWords(message);

            foreach (var matchedWord in matchedWords)
            {
                point += matchedWords[matchedWord.Key];
            }

            return point;
        }
    }
}
