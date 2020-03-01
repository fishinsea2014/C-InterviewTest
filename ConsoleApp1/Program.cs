using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

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

            string str1 = "abc";
            string str2 = "abc";
            Console.WriteLine(str1==str2);
            Console.WriteLine(str1.Equals(str2));
            StringBuilder str3 = new StringBuilder("abc");
            Console.WriteLine(str1.Equals(str3));
            Console.Read();

        }       
      
    }
    
}
