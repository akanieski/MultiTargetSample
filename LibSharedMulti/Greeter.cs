using System;
#if !NET46
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
#endif
namespace LibSharedMulti
{
    public class Greeter
    {
        public static void SayHello()
        {
            string value = "";
#if !NET46
            // CODE HERE IS .NET STANDARD FRIENDLY and you can use ConfigBuilder
            ConfigurationBuilder builder = new ConfigurationBuilder();
            value = "Test from .net Standard logic";

            // Assuming all env variables prefixed with "CONFIG_"
            //    .AddEnvironmentVariables("CONFIG_");

#else
            // CODE HERE IS .NET 4.6.0 FRIENDLY
            value = "Test from non-standard logic";
#endif

            Console.WriteLine(value);
        }
    }
}
