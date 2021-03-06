﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Abc.NCrafts.Quizz
{
    public static class Logger
    {
        public static bool Enabled { get; set; }

        [Conditional("DEBUG")]
        public static void Log<T>(T value)
        {
            if (Enabled)
                Console.WriteLine(value?.ToString());
        }

        [Conditional("DEBUG")]
        public static void Log<T>(string format, T arg0)
        {
            if (Enabled)
                Console.WriteLine(format, arg0);
        }

        [Conditional("DEBUG")]
        public static void Log(string format, IEnumerable<int> arg0)
        {
            if (Enabled)
                Console.WriteLine(format, string.Join(", ", arg0));
        }
    }
}
