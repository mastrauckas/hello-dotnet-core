using System;

namespace hello_dotnet_core
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Hello from dotnet core:");
            Console.WriteLine($"      Platform: {System.Runtime.InteropServices.RuntimeInformation.OSDescription}");
            Console.WriteLine($"      Framework: {Microsoft.Extensions.PlatformAbstractions.PlatformServices.Default.Application.RuntimeFramework.Version}");
        }
    }
}
