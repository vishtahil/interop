using System;
using System.Runtime.InteropServices;

namespace CoreNativeTest
{
    class Program
    {
        [DllImport(@"ReferenceAssembly\\libhello-cpp.so")]
        public static extern void PrintHelloWorld();

        [DllImport(@"ReferenceAssembly\\libhello-cpp.so")]
        public static extern int add(int a , int b);

        static void Main(string[] args)
        {
            PrintHelloWorld();
            var output= add(7,8);
            Console.WriteLine("output:"  + output);
        }
    }
}
