using System.Diagnostics;
using System.Threading;

namespace PositiveResourceIds
{
    public class Program
    {
        public static void Main()
        {
            // This works fine as do any resource with a negative id
            var stringNegativeId = Resource1.GetString(Resource1.StringResources.StringNegativeId);
            Debug.WriteLine($"Resource1.StringResources.StringNegativeId [-10741]: {stringNegativeId}");

            // This fails when the code on the device tries to load the resource
            var stringPositiveId = Resource2.GetString(Resource2.StringResources.StringPositiveId);
            Debug.WriteLine($"Resource2.StringResources.StringPositiveId [12314]: {stringPositiveId}");

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
