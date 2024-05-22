using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingTypeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int numeroInt = 1500;
            Type numeroIntType = numeroInt.GetType();
            TypeCode numeroIntTypeCode = numeroInt.GetTypeCode();
            double numeroDouble = numeroInt;
            Type numeroDoubleType = numeroDouble.GetType();
            TypeCode numeroDoubleTypeCode = numeroDouble.GetTypeCode();

            Console.WriteLine($"Numint is equal to: {numeroInt}");
            Console.WriteLine($"Numint Type is: {numeroIntType}");
            Console.WriteLine($"Numint TypeCode is: {numeroIntTypeCode}");

            Console.WriteLine($"\n\n\nNumDouble is equal to: {numeroDouble}");
            Console.WriteLine($"NumDouble Type is: {numeroDoubleType}");
            Console.WriteLine($"NumDouble TypeCode is: {numeroDoubleTypeCode}");

            double numDouble2 = 1.23;
            int numint2 = (int)numDouble2;
            Type numDouble2Type = numint2.GetType();

            Console.WriteLine($"\n\n\nValue of Double was: {numDouble2}\nAfter casting conversion it becomes: {numint2}");
            Console.WriteLine($"\n\n\nType was: {numDouble2.GetType()}\nAfter casting conversion it becomes: {numint2.GetType()}");

            */
            int numero2 = 500;
            byte numer2Byte = (byte)numero2;
            Console.WriteLine($"\n\n\nValue of numero2 was: {numero2}\nAfter casting conversion it becomes: {numer2Byte}");
            Console.WriteLine($"\n\n\nType was: {numero2.GetType()}\nAfter casting conversion it becomes: {numer2Byte.GetType()}");



            Console.Read();
        }
    }
}
