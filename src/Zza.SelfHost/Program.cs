using System;
using System.ServiceModel;
using ZzaApp.Services;

namespace Zza.SelfHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var host = new ServiceHost(typeof(ZzaService));
                host.Open();
                Console.WriteLine("Hit any key to exit");
                Console.ReadKey();
                host.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}