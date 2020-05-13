using System;
using System.Collections.Generic;
using System.Text;

namespace ClientOrder
{
    public class ClientOrder
    {
        public void UseDiscount(Client client, Order order)
        {
            //Basic client has no discount
            
            //Premium client has 15% discount
            if (client.TypeOfClient == TypeOfClient.Premium)
            {
                order.Sum = order.Sum - ((order.Sum * 15)/100);
            }
            //Special client has 30% discount
            else if (client.TypeOfClient == TypeOfClient.SpecialClient)
            {

                order.Sum = order.Sum - ((order.Sum * 30)/100);
            }
        }
    }
}