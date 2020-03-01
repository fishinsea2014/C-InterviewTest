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
            string str1 = "\U0010FADE";
            Console.WriteLine(str1+","+str1.Length);
            string str2 = "\U0000FADE"; //\U0000 is Empty
            Console.WriteLine(str2 + "," + str1.Length);

            Console.Read();

        }

        
      
    }
    
}
