using System;
using System.ServiceModel;

namespace HelloServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloWCF.HelloService)))
            {
                host.Open();
                /*Error: {"A binding instance has already been associated to listen URI 'http://localhost:8080/HelloService'. If two endpoints want to share the same ListenUri, they must also share the same binding object instance. The two conflicting endpoints were either specified in AddServiceEndpoint() calls, in a config file, or a combination of AddServiceEndpoint() and config. "}
                 Solution. changes mex address to different than main endpoints
                 
                Error: HTTP could not register URL http://+:8080/. Your process does not have access rights to this namespace (see http://go.microsoft.com/fwlink/?LinkId=70353 for details).
                 */
                Console.WriteLine("Host has started.");
                Console.ReadKey();
            }
        }
    }
}
