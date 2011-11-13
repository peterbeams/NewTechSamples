using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzWare.NBuilder.Generators;
using MyMessages;
using NServiceBus;

namespace OrderPlacementApplication
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher { }

    public class ServerEndPoint : IWantToRunAtStartup
    {
        public IBus Bus { get; set; }

        public void Run()
        {
            Console.WriteLine("Application Starting...");
            Console.WriteLine("Press enter to create an order");

            while (Console.ReadLine() != null)
            {
                var message = Bus.CreateInstance<IOrderPlaced>();
                message.Id = GetRandom.Int();
                message.Product = GetRandom.Phrase(30);
                message.Qty = GetRandom.Int(1, 10);
                Bus.Publish(message);
                Console.WriteLine("Publishing Event");
            }
        }

        public void Stop()
        {

        }
    }
}
