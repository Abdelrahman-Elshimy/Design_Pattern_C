using MiHR;
using System;

namespace Metigator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            string s1 = "dfsfds";
            string s2 = s1 + "" + "ddsf";

            string s3 = $"{s1} {s2}";

            Console.WriteLine(s2);
            Console.WriteLine(s3);

        }
    }
}
