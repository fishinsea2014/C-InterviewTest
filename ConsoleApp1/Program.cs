using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConsoleApp1
{
    static class Extensions
    {
        #region Q31
        public static void Assign(this int i)
        {
            Console.WriteLine(Program.i);
            Console.WriteLine(i);
        }
        #endregion
    }
    /// <summary>
    /// Exercise from 
    /// https://www.techbeamers.com/csharp-coding-interview-questions-developers/
    /// </summary>
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region archived
            /**
            //int[] arr = new int[2];
            //arr[1] = 10;
            //Object o = arr;
            //int[] arr1 = (int[])o;
            //arr1[1] = 100;
            //Console.WriteLine(arr[1]);
            //IDictionary<int, string> test = new Dictionary<int, string>();
            //test.Add(new KeyValuePair<int, string>(1, "one"));
            //bool contain = test.Contains(new KeyValuePair<int, string>(1, "one"));


            //var x = 'A';
            //Console.WriteLine(true ? x:0);
            
            int num1 = 20;
            int num2 = 30;
            num1 ^= num2^=num1;
            Console.WriteLine(num1 +",  "+num2);
            num1 = 20;
            num2 = 30;
            num2 ^= num1;
            num1 ^= num2;
            Console.WriteLine(num1 + ",  " + num2);

            
            string[] strings = { "abc", "abc2", "abc3" };
            var actions = new List<Action>();
            foreach (string str in strings)
            {
                actions.Add(() => { Console.WriteLine(str); });
            }

            foreach (var action in actions)
            {
                action();
            }
            //Question 15
            del str = new del(sample.DelegateSample);
            string str1 = str("welcom,, friends,, to ,, teach");
            Console.WriteLine(str1);
            var actions = new List<Action>();
            for (int i =0; i < 4; i++)
            {
                actions.Add(() => Console.WriteLine(i));
                foreach (var action in actions)
                {
                    action();
                }
            }
     

            testDelegate obj = new testDelegate();
            sampleDelegate delegateObj = new sampleDelegate(obj.checkEven);
            delegateObj += new sampleDelegate(obj.squareNumber);
            delegateObj(25);

            ====q17====
            var arr = new List<int> { 20, 40, 35, 85, 70 };
            var collection = new Collection<int>(arr);
            arr.Add(60);
            arr.Sort();
            Console.WriteLine(String.Join(",", collection));

            ====Q22====
            classC a = new classC();
            Console.WriteLine(a.Print());

            ===q26===
            {
                int i, j = 1, k;
                for (i = 0; i < 5; i++)
                {
                    k = j++ + ++j;
                    Console.Write(k+ ", ");
                }

            }

            ==q30==
            int[] arr = { 1, 2, 3 };
            int i = 1;
            arr[i++] =
                arr[i] + 10;
            Console.WriteLine(String.Join(",",arr));

            ==q31==
            (i++).Assign();

            ==q32==
            Console.WriteLine((int)Color.red+ ", " + (int) Color.green + ", " +
                (int)Color.blue+ ", " + (int)Color.cyan+ ", " + (int)Color.magenta+
                ", " + (int)Color.yellow); // 0,1,5,6,11

            ==q34==
            var test = SingletonB.Test;
            test.GetType();

            ==q35==
            Environment.Exit(0);

            ==q37==
            Drived d = new Drived();
            int i = 0;
            d.Func(i);
    */
            #endregion            

        }
        #region Q33
        static void f1(ref int num)
        {
            num += num;
        }
        static void f2(out int num)
        {
            //num+=num 报错，usage of unassigned out parameter.
            num = 3;
        } 
        #endregion
    }
    #region Q37
    public class Base
    {
        public virtual void Func(int x)
        {
            Console.WriteLine("base.Func(int)");
        }
    }

    public class Drived : Base
    {
        public override void Func(int x)
        {
            Console.WriteLine("Derived.Func(int)");
        }
        public void Func(Object o)
        {
            Console.WriteLine("Derived.func(obj)");
        }
    } 
    #endregion
    #region Q34
    class SingletonB
    {
        static readonly SingletonB _instance = new SingletonB();
        public static SingletonB Test { get { return _instance; } }
        private SingletonB()
        {
            Console.WriteLine("Default Constructor");
        }

        static SingletonB()
        {
            Console.WriteLine("Static Constructor");
        }
    }
    #endregion
    #region Q32
    //enum Color : int
    //{
    //    red, green, blue = 5,
    //    cyan, magenta = 10,
    //    yellow
    //} 
    #endregion
    #region Q22
    //public class classA
    //{
    //    public virtual string Print()
    //    {
    //        Console.WriteLine("class a");
    //        return "classA";
    //    }
    //}
    //public class classB : classA
    //{
    //    public override string Print()
    //    {
    //        Console.WriteLine("class b");
    //        return "classB";
    //    }
    //}
    //public class classC : classB
    //{
    //    public new string Print()
    //    {
    //        Console.WriteLine("class c");
    //        return "ClassC";
    //    }
    //}
    #endregion
    #region Question 15
    //delegate string del(string str);
    //class sample
    //{
    //    public static string DelegateSample(string a)
    //    {
    //        return a.Replace(',', '*');
    //    }
    //} 
    #endregion

    #region Q 16
    //public delegate void sampleDelegate(int num);
    //public class testDelegate
    //{
    //    public void checkEven(int num)
    //    {
    //        if (num % 2 == 0)
    //        {
    //            Console.WriteLine("even number");
    //        }
    //        else
    //        {
    //            Console.WriteLine("odd number");
    //        }


    //    }
    //    public void squareNumber(int num)
    //    {
    //        Console.WriteLine("Square is: {0}", num * num);
    //    }
    //} 
    #endregion
}
