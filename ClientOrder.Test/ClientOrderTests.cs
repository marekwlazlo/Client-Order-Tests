using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ClientOrder.Test
{
    [TestFixture]
    public class ClientOrderTests
    {
        [TestCase]
        public void When_PremiumClient_Expect_15PercentDiscountTrue()
        {
            
            Client premiumClient = new Client
            {
                ClientId = 1,
                ClientName = "Patryk Duda",
                TypeOfClient = TypeOfClient.Premium
            };

            Order order = new Order
            {
                OrderId = 1,
                ProductId = 14,
                ProductQuantity = 1,
                Sum = 1000
            };


            ClientOrder clientOrder = new ClientOrder();
            clientOrder.UseDiscount(premiumClient, order);
            Assert.AreEqual(order.Sum, 850);
        }

        [TestCase]

        //Test doesn't work because sum should has 3500

        public void When_SpecialClient_Expect_30PercentDiscountFalse()
        {

            Client premiumClient = new Client
            {
                ClientId = 15,
                ClientName = "Harry Kane",
                TypeOfClient = TypeOfClient.SpecialClient
            };

            Order order = new Order
            {
                OrderId = 2,
                ProductId = 23,
                ProductQuantity = 1,
                Sum = 5000
            };


            ClientOrder clientOrder = new ClientOrder();

            clientOrder.UseDiscount(premiumClient, order);

            Assert.AreEqual(order.Sum, 3400);
        }

        [TestCase]
        public void When_BasicClient_Hasnt_DiscountTrue()
        {

            Client premiumClient = new Client
            {
                ClientId = 3,
                ClientName = "Alicja Polska",
                TypeOfClient = TypeOfClient.Basic
            };

            Order order = new Order
            {
                OrderId = 21,
                ProductId = 49,
                ProductQuantity = 1,
                Sum = 1430
            };


            ClientOrder clientOrder = new ClientOrder();
            clientOrder.UseDiscount(premiumClient, order);
            Assert.AreEqual(order.Sum, 1430);
        }

        [TestCase]
        //Test doesn't work because sum should has 1700
        public void When_PremiumClient_Expect_15PercentDiscountFalse()
        {

            Client premiumClient = new Client
            {
                ClientId = 15,
                ClientName = "Andrzej Kizo",
                TypeOfClient = TypeOfClient.Premium
            };

            Order order = new Order
            {
                OrderId = 155,
                ProductId = 3,
                ProductQuantity = 1,
                Sum = 2000
            };


            ClientOrder clientOrder = new ClientOrder();
            clientOrder.UseDiscount(premiumClient, order);
            Assert.AreEqual(order.Sum, 1600);
        }
        [TestCase]
        
        public void When_SpecialClient_Expect_30PercentDiscounTrue()
        {

            Client premiumClient = new Client
            {
                ClientId = 199,
                ClientName = "Grzegorz Brodacz",
                TypeOfClient = TypeOfClient.SpecialClient
            };

            Order order = new Order
            {
                OrderId = 255,
                ProductId = 87,
                ProductQuantity = 1,
                Sum = 790
            };


            ClientOrder clientOrder = new ClientOrder();

            clientOrder.UseDiscount(premiumClient, order);

            Assert.AreEqual(order.Sum, 553);
        }

        [TestCase]
        public void When_BasicClient_Hasnt_DiscountFalse()
        {

            Client premiumClient = new Client
            {
                ClientId = 53,
                ClientName = "Lionel Messi",
                TypeOfClient = TypeOfClient.Basic
            };

            Order order = new Order
            {
                OrderId = 21,
                ProductId = 49,
                ProductQuantity = 1,
                Sum = 658
            };


            ClientOrder clientOrder = new ClientOrder();
            clientOrder.UseDiscount(premiumClient, order);
            Assert.AreEqual(order.Sum, 460);
        }

    }
}