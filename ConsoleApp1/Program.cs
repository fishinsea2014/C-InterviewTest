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
        public Program(object o)
        {
            Console.WriteLine("Object argument");
        }

        public Program(double[] arr)
        {
            Console.WriteLine("double array argument");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("C# interview test");
            new Program(null);
            Console.Read();

        }       
      
    }
    
}
