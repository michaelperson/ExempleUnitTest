using System;

namespace ExempleUnitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Operations op = new Operations(12,15);
            if (op.Addition() != 6)
            {
                Console.WriteLine($"Vous me devez { op.Addition() }");
            }
        }
    }
}
