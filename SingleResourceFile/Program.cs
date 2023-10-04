using System;
using System.Diagnostics;
using System.Threading;

namespace SingleResourceFile
{
    public class Program
    {
        public static void Main()
        {
            // These both work fine with only a single resource file defined.
            var stringNegativeId = Resource1.GetString(Resource1.StringResources.StringNegativeId);
            Debug.WriteLine($"Resource1.StringResources.StringNegativeId [-10741]: {stringNegativeId}");

            var stringPositiveId = Resource1.GetString(Resource1.StringResources.StringPositiveId);
            Debug.WriteLine($"Resource1.StringResources.StringPositiveId [12314]: {stringPositiveId}");

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
