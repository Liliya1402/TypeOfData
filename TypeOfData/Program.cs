using System;

namespace TypeOfData
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Type\t {0,10} {1,18} {2,30}", "Bytes(s) of Memory", "Min", "Max");

            Console.WriteLine("");
            Console.WriteLine("sbyte\t {0,6} {1,30} {2,30}", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);

            Console.WriteLine("byte\t {0,6} {1,30} {2,30}", sizeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine("short\t {0,6} {1,30} {2,30}", sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine("ushort\t {0,6} {1,30} {2,30}", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("int\t {0,6} {1,30} {2,30}", sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine("uint\t {0,6} {1,30} {2,30}", sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine("long\t {0,6} {1,30} {2,30}", sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine("ulong\t {0,6} {1,30} {2,30}", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("float\t {0,6} {1,30} {2,30}", sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine("double\t {0,6} {1,30} {2,30}", sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine("decimal\t {0,6} {1,30} {2,30}", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
            Console.ReadKey();
        }
    }
}
