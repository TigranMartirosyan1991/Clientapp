using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Clientapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri _uri = new Uri("http://Localhost:8088/ServiseRelasietion");
            BasicHttpBinding basic = new BasicHttpBinding();
            ChannelFactory<IContract> channel = new ChannelFactory<IContract>(basic, new EndpointAddress(_uri));
            var OpenChannel = channel.CreateChannel();
            while (true) {

                string text = Console.ReadLine();
                if (text == "EXIT")
                { break; }
                else {


                    Console.WriteLine(OpenChannel.gettikotime(text));
                }
         
        }
        }
    }
}
