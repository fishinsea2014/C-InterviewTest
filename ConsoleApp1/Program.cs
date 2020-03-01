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
            double d1 = 1.000001;
            double d2 = 0.000001;
            Console.WriteLine((d1-d2).Equals(1.0));
            //浮点运算比较复杂
            //https://blog.csdn.net/u012557765/article/details/81869391
            Console.Read();

        }       
      
    }
    
}
