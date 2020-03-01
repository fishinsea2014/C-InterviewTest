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
            Console.WriteLine("Hello World!");
            Sample s = new Sample();
            s.Print();
            ISample i = s;
            i.Print();

            Console.Read();

        }

        public interface ISample
        {
            void Print(string val = "Interface Executed");
        }

        public class Sample : ISample
        {
            public void Print (string val = "Class Executed")
            {
                Console.WriteLine(val);
            }
        }
      
    }
    
}
