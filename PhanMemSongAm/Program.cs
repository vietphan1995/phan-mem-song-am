// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

namespace PhanMemSongAm
{
    class Program
    {
        private static bool _isInSleep = true;

        static void Main()
        {
            Thread sleepThread = new Thread(Sleep)
            {
                IsBackground = true,
            };

            sleepThread.Start();

            while (_isInSleep)
            {
                string inputMessage = Console.ReadLine();
                Console.WriteLine();
                Console.Write($"[input message]: {inputMessage}");

                var message = new Message(inputMessage);
                message.PrintMe();
                message.PrintNames();
                message.PrintParameters();
                message.PrintPositivePoint();
                message.TrimDoubleQuote();
            }


        }

        static void Sleep()
        {

            // dang dung
            do
            {
                if (_isInSleep == false)
                {
                    _isInSleep = true;
                }

                Thread.Sleep(3000);

                _isInSleep = false;
            } while (_isInSleep == false);


        }
    }
    
}

