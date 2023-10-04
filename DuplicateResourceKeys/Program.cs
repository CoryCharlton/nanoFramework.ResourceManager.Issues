using System;
using System.Diagnostics;
using System.Threading;

namespace DuplicateResourceKeys
{
    public class Program
    {
        public static void Main()
        {
            // This example does not build
            Debug.WriteLine("Hello from nanoFramework!");

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
