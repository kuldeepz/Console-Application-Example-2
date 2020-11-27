using System;

namespace Console_Application_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compare Function
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int n = string.Compare(s1, s2, true);
            //int n = s1.CompareTo(s2);  
            Console.Write(n);
            Console.ReadLine();

            //Contains Function
            string s3 = Console.ReadLine();
            string s4 = Console.ReadLine();
            bool b;
            b = s4.Contains(s3);
            Console.Write(b);
            Console.ReadLine();
        }
    }
}
