﻿using System;
using System.Diagnostics;
using System.Threading;
using ConsoleZ;
using ConsoleZ.Win32;

namespace ConsoleZ.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectConsole.Setup(80, 30, 16, 16, "Consolas");
            //DirectConsole.Test();

            var screen = DirectConsole.Singleton;

            var frameCount = 2000;
            Console.WriteLine(Benchmark(frameCount, screen));
        }

        private static string Benchmark(int frameCount, IBufferedAbsConsole<CHAR_INFO> screen)
        {
            var r = new Random();
            var stop = new Stopwatch();
            stop.Start();
            for (int i = 0; i < frameCount; i++)
            {
                var x = r.Next(screen.Width);
                var y = r.Next(screen.Height);
                var a = r.Next(26);
                var clr = r.Next(0, 255);

                screen[x, y] = new CHAR_INFO(TestHelper.GetCharOffset('A', a), (ushort)clr);
                screen.Update();

                if (i % 50 == 0)
                {
                    System.Console.Title = i.ToString();
                }
            }

            stop.Stop();
            return $"{frameCount} frames in {stop.Elapsed} at {frameCount / stop.Elapsed.TotalSeconds} FPS";
        }
    }
}
