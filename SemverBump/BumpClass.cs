using System.Reflection;

namespace SemverBump
{
    public class BumpClass
    {
        //Reference: https://edi.wang/post/2018/9/27/get-app-version-net-core
        public void PrintVersion()
        {
            Assembly execAssembly = Assembly.GetCallingAssembly();

            AssemblyName name = execAssembly.GetName();

            Console.WriteLine($"GetType().Assembly.GetName().Version: " +
                              $"{GetType().Assembly.GetName().Version.ToString()}");

            Console.WriteLine($"Assembly.GetEntryAssembly().GetName().Version: " +
                              $"{Assembly.GetEntryAssembly().GetName().Version}");

            Console.WriteLine($"Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyFileVersionAttribute>().Version:" +
                              $"{Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyFileVersionAttribute>().Version}");

            Console.WriteLine($"Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion:" +
                              $"{Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion}");


            Console.WriteLine(string.Format("{0}{1} {2:0}.{3:0} for .Net ({4}){0}",
                Environment.NewLine,
                name.Name,
                name.Version?.Major.ToString(),
                        name.Version?.Minor.ToString(),
                execAssembly.ImageRuntimeVersion
                ));

            Console.WriteLine("teste");
        }
    }
}