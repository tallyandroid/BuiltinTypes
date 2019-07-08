using System;

namespace BuiltinTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"byte: minimum {byte.MinValue}, maximum {byte.MaxValue}");
            Console.WriteLine($"sbyte: minimum {sbyte.MinValue}, maximum {sbyte.MaxValue}");
            Console.WriteLine($"short: minimum {short.MinValue}, maximum {short.MaxValue}");

            Console.WriteLine($"int: minimum {int.MinValue}, maximum {int.MaxValue}");
            Console.WriteLine($"long: minimum {long.MinValue}, maximum {long.MaxValue}");



        }
    }
}
