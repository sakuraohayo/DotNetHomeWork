using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Goods goods1 = new Goods("football", 1);                                          //测试数据
            Goods goods2 = new Goods("basketball",2);
            Goods goods3 = new Goods("volleyball", 3);
            Goods goods4 = new Goods("water", 4);
            Goods goods5 = new Goods("chocolate", 5);

            Client client1 = new Client("hm");
            Client client2 = new Client("wh");
            Client client3 = new Client("zm");

            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem orderItem3 = new OrderItem(goods3, 3);
            OrderItem orderItem4 = new OrderItem(goods4, 4);
            OrderItem orderItem5 = new OrderItem(goods5, 5);

            OrderItem[] orderItems1 = { orderItem1, orderItem5};
            OrderItem[] orderItems2 = { orderItem2, orderItem3};
            OrderItem[] orderItems3 = { orderItem2, orderItem3, orderItem4 };

            Order order1 = new Order(1, client1, orderItems1);
            order1.calculate();
            Order order2 = new Order(2, client2, orderItems2);
            order2.calculate();
            Order order3 = new Order(3, client3, orderItems3);
            order3.calculate();

            OrderService orderService = new OrderService();
            orderService.add(order2);
            orderService.add(order1);
            orderService.add(order3);
            Console.Write("当前保存的订单编号序列: ");
            orderService.showID();
            Console.WriteLine();
            Console.Write("默认排序后的订单编号序列: ");
            orderService.sort();
            orderService.showID();
            Console.WriteLine();
            Console.WriteLine("删除订单编号为3的订单");
            orderService.sub(003);
            Console.Write("当前保存的订单编号序列: ");
            orderService.showID();
            Console.WriteLine("\n");
            Console.WriteLine("查询hm的订单");
            List<Order> porders = orderService.querybyClient("hm");
            foreach (Order order in porders)
            {
                Console.Write(order);
            }
            Console.ReadKey();
        }
    }
}
    

