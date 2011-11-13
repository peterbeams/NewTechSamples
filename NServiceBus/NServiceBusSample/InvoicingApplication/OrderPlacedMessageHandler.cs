using System;
using log4net;
using MyMessages;
using NServiceBus;

namespace InvoicingApplication
{
    public class OrderPlacedMessageHandler : IHandleMessages<IOrderPlaced>
    {
        public void Handle(IOrderPlaced message)
        {
            Logger.Info(string.Format("Printing Invoice For Order [Id='{0}', Product='{1}', Qty='{2}']", message.Id, message.Product, message.Qty));
        }

        private static readonly ILog Logger = LogManager.GetLogger(typeof(OrderPlacedMessageHandler));
    }
}