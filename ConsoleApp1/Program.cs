using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConsoleApp1
{
    
    /// <summary>
    /// Exercise from 
    /// https://www.techbeamers.com/csharp-coding-interview-questions-developers/
    /// </summary>
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("C# interview test");
            float num = 45;
            var div = num / 0;
            // int, long divided by 0 get DivideByZeroException error
            // float, double divided by 0 get Infinity
            Console.WriteLine(div);
            Console.Read();

        }

        
      
    }
    
}
