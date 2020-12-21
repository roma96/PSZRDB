using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace NetRemoting
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpServerChannel channel = new TcpServerChannel(9990);

                //Code configuration
                ChannelServices.RegisterChannel(channel, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(DatabaseManangerServer), "DatabaseMananger", WellKnownObjectMode.SingleCall);

                //Config file configuration
                //string config = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
                //Console.WriteLine(config);
                //RemotingConfiguration.Configure(config, false);
                WellKnownServiceTypeEntry[] conf = RemotingConfiguration.GetRegisteredWellKnownServiceTypes();
                Console.WriteLine(string.Concat("Server running\n",conf[0]));
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Can't start server!");
                Console.ReadLine();
            }
        }
    }
}
