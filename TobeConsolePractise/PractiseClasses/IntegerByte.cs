﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobeConsolePractise
{
    /// <summary>
    /// To est integer and byte default values as well as overflow
    /// </summary>
    class IntegerByte
    {
        private int a { get; set; }  //defaults to 0
        private byte b { get; set; }  //defaults to 0
        private string c { get; set; }  //defaults to "" or null
        
        public static void run()
        {
            IntegerByte i = new IntegerByte();
            Console.WriteLine("The int is: {0}, the byte is: {1} and {{the sring is: {2}", i.a, i.b, i.c); // {{ escapes curly brace
            //b = 255; is possible but b=256 is impossible
            Console.ReadKey();
        }
    }
}
