// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

using System;
using System.Threading;


namespace PhanMemSongAm1
{
    class Program
    {
        //private static bool _isRunning = true;
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
                string message = Console.ReadLine();

                Console.WriteLine($"moi vua nhap: {message}");
            }


        }

        static void Sleep()
        {
            //while (_isRunning)
            //{
            //    Console.WriteLine("isRunning");

            //    if (_isInSleep == false)
            //    {
            //        _isInSleep = true;
            //        Console.WriteLine("isInSleep");

            //        while (_isInSleep)
            //        {
            //            Thread.Sleep(3000);

            //            _isInSleep = false;
            //        }
            //    }
            //}

            // dang dung
            do
            {
                if (_isInSleep == false)
                {
                    _isInSleep = true;
                }

                Console.WriteLine("start sleep");

                Thread.Sleep(3000);

                Console.WriteLine("end sleep");

                _isInSleep = false;
            } while (_isInSleep == false);



            //while (_isInSleep)
            //{
            //    Console.WriteLine("is in sleep");

            //    _isInSleep = false;

            //    Console.WriteLine("is in sleep false");

            //    Thread.Sleep(3000);

            //    //Task.Delay(3000);

            //    _isInSleep = true;

            //    Console.WriteLine("is in sleep true");
            //}
        }
    }
    
}

