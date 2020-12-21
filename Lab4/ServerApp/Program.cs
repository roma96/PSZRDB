using Models;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfServer;

namespace ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVER";
            //Configuration from file (should be uncommented also app.config file)
            //ServiceHost host = new ServiceHost(typeof(Repository));

            //configuration from code
            ServiceHost host = new ServiceHost(typeof(Repository), new Uri("http://localhost:8000/EmployeeRepository/"));

           BasicHttpBinding binding = new BasicHttpBinding();
            binding.CloseTimeout = new TimeSpan(0, 1, 0);
            binding.ReceiveTimeout = new TimeSpan(0, 1, 0);

            host.AddServiceEndpoint(typeof(IEmployeeRepository), binding, "");
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);
            host.Open();

            Console.WriteLine("Endpoint started");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
