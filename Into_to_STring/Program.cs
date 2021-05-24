using System;

namespace Into_to_STring
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hellow";
            string b = "h";
            //Append to contests of 'b'
            b += "ellow";
            Console.WriteLine(a == b);
            Console.WriteLine((object)a == (object)b);
        }
    }
}
