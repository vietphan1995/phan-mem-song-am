using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemSongAm
{
    // "anh Nam va Viet la 2 anh em nhung khong thich giet nguoi"
    // ""Vậy theo Việt thì phải làm sao?" Của ai?, cho nó biết mà Phúc phải chạy theo"
    // """Vậy theo Việt thì phải làm sao?" Của ai?, cho nó biết mà Phúc phải chạy theo"
    // " a " b " c " d "
    // thứ tự " > ' > . > ; > ,?! > :
    // tổ hợp địa chỉ dấu ngoặc "
    // ., có nghĩa "w(who/whom/which/so/because/how) + s(subject) + v(verb) + o(object) + a(adv/adj)" -> có điểm liên quan co- trong xã hội ghép
    // what/why/how/not -> không có nghĩa

    internal class Quote
    {
        private int from = -1;
        private int to = -1;
        private string _content = "";
        public Quote(string input)
        {
            this._content = input;
        }

        static void ToQuotes(string input)
        {
            
            var doubleQuotes = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '\"')
                {
                    doubleQuotes.Append(c);
                }
            }


        }
    }

    class QuoteDict : Dictionary<string, Quote> 
    {
        
    }
}
