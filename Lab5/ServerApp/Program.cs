using Ch.Elca.Iiop;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using WcfServer;

namespace ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVER";
            try
            {
                int serverPort = 1234;
                IiopChannel channel = new IiopChannel(serverPort);
                ChannelServices.RegisterChannel(channel);

                EmployeeRepository repository = new EmployeeRepository();
                string objectURI = "hello";
                RemotingServices.Marshal(repository, objectURI);

                Console.WriteLine("Endpoint started");
                Console.WriteLine("Press any key to exit");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
