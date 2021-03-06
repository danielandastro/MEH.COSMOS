﻿using System;
using System.Collections.Generic;
using Display;
using Hardware;
using Sys = Cosmos.System;

namespace MEH.COSMOS
{
    public class Kernel: Sys.Kernel
    {
        protected override void BeforeRun()
        {
            DisplayDriver display = new DisplayDriver();
            display.init();
            Console.WriteLine("Welcome to the MEH OS 0.1, built on the COSMOS kernel");
            Console.WriteLine("WARNING; This OS is PRE-ALPHA, and not a substitute for your main OS");
            Console.WriteLine("We are not responsible if you lose your data");
        }
        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}
