using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var euro = 1;
            Console.WriteLine(Extension.Extensions.ConvertToEuro(euro));
            Console.WriteLine(Extension.Extensions.ConvertToUsd(1));

            Console.WriteLine(Extension.Extensions.GetEnum(Extension.Enum.UserType1));
            Console.WriteLine(Extension.Extensions.GetEnum(Extension.Enum.UserType3));
            Console.ReadLine();
        }
    
    }
}
