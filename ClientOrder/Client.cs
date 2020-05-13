using System;
using System.Collections.Generic;
using System.Text;

namespace ClientOrder
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public TypeOfClient TypeOfClient { get; set; }
    }
}