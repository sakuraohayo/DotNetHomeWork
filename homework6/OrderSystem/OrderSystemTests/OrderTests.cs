using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService a = new OrderService();
        [TestMethod()]
        public void add()
        {
            Client client1 = new Client("z");
            Goods goods1 = new Goods("football", 1);                                          //测试数据
            Goods goods2 = new Goods("basketball", 2);
            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem[] orderItems1 = { orderItem1, orderItem2 };
            Order order1 = new Order(1, client1, orderItems1);
            a.add(order1);
        }
        [TestMethod()]
        public void sort()
        {
            Client client1 = new Client("z");
            Goods goods1 = new Goods("football", 1);                                          //测试数据
            Goods goods2 = new Goods("basketball", 2);
            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem[] orderItems1 = { orderItem1, orderItem2 };
            Order order1 = new Order(1, client1, orderItems1);
            Order order3 = new Order(1, client1, orderItems1);
            Order order2 = new Order(1, client1, orderItems1);
            a.add(order1);
            a.add(order3);
            a.add(order2);
            a.sort();
        }
        [TestMethod()]
        public void sub()
        {
            Client client1 = new Client("z");
            Goods goods1 = new Goods("football", 1);                                          //测试数据
            Goods goods2 = new Goods("basketball", 2);
            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem[] orderItems1 = { orderItem1, orderItem2 };
            Order order1 = new Order(1, client1, orderItems1);
            Order order2 = new Order(2, client1, orderItems1);
            a.add(order1);
            a.add(order2);
            a.sub(1);
        }
        [TestMethod()]
        public void modify()
        {
            Client client1 = new Client("z");
            Goods goods1 = new Goods("football", 1);                                          //测试数据
            Goods goods2 = new Goods("basketball", 2);
            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem[] orderItems1 = { orderItem1, orderItem2 };
            OrderItem[] orderItems2 = { orderItem1 };
            Order order1 = new Order(1, client1, orderItems1);
            Order order2 = new Order(1, client1, orderItems2);
            a.add(order1);
            a.modify(1, order2);
        }
    }
}