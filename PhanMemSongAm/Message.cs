using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemSongAm
{
    internal class Message : Command
    {
        private string _content = "";
        public Message(string input) : base(input)
        {
            this._content = input;
            this._positivePoint = BagOfPositive.GetPoint(this._content);

            // (" ")
            // toCommand
        }

        public void PrintMe()
        {
            Console.WriteLine();
            Console.Write($"PrintMe: {this._content}");
        }

        public void PrintNames()
        {
            Console.WriteLine();
            Console.Write($"PrintNames: ");

            var names = Name.GetNames(this._message);

            for (int j = 0; j < names.Count; j++)
            {
                Console.Write($"{names[j]}, ");
            }
        }


        private int _positivePoint = 0;

        public void PrintPositivePoint()
        {
            Console.WriteLine();
            Console.Write($"PrintPositivePoint: {this._positivePoint}");
        }

        public void TrimDoubleQuote()
        {
            var trimDoubleQuote = DoubleQuote.Trim(this._message);

            Console.WriteLine();
            Console.Write($"TrimDoubleQuote: {trimDoubleQuote}");

        }
    }
}
