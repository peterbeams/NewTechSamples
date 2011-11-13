using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace MyMessages
{
    public interface IOrderPlaced : IMessage
    {
        int Id { get; set; }
        string Product { get; set; }
        int Qty { get; set; }
    }
}
