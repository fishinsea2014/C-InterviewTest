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
            int[,] multiDimArray = { { 1, 3 }, { 6, 8 } };
            Console.WriteLine(multiDimArray[0,0]+", length"+multiDimArray.Length);
            Console.Read();

        }

        
      
    }
    
}
