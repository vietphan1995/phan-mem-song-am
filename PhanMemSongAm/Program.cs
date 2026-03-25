// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

using System;
using System.Threading;


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

            var nameDetector = new NameDetector();

            while (_isInSleep)
            {
                string inputMessage = Console.ReadLine();

                Console.WriteLine($"[message]: {inputMessage}");

                nameDetector.Detect(inputMessage);

                var messageCommand = new MessageCommand(inputMessage);
                messageCommand.Print();

                var bagOfPositive = new BagOfPositive();
                var point = bagOfPositive.GetPoint(inputMessage);
                Console.WriteLine($"point: {point}");
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

                //Console.WriteLine("start sleep");

                Thread.Sleep(3000);

                //Console.WriteLine("end sleep");

                _isInSleep = false;
            } while (_isInSleep == false);


        }
    }
    
}

