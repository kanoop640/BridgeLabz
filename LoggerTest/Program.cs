﻿//<auto-generated/>
using LoggerTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace LoggerTest
{

    class Program
    {
    private static readonly log4net.ILog log = LogHelper.GetLog();  //log4net.LogManager.GetLogger("Program.cs");
        static void Main(string[] args)
        {
            Console.WriteLine("hello .net ");
            log.Info("Helo This is info statement");
            log.Error("It is system error");
            Console.ReadLine();
            add(10, 20);
        }

        public static void add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine(z);
        }
    }
}
