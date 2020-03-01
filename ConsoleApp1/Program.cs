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
            for (int x = 0; x < 10;x++)
            {

                Console.Write(x +' ');
            }

            //Output:32333435363738394041
            //number of ' ' is 32
            Console.Read();

        }       
      
    }
    
}
