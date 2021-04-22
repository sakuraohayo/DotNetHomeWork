using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

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

            Client client1 = new Client("z");
            Client client2 = new Client("zz");
            Client client3 = new Client("zzz");

            OrderItem orderItem1 = new OrderItem(goods1, 1);
            OrderItem orderItem2 = new OrderItem(goods2, 2);
            OrderItem orderItem3 = new OrderItem(goods3, 3);
            OrderItem orderItem4 = new OrderItem(goods4, 4);
            OrderItem orderItem5 = new OrderItem(goods5, 5);

            OrderItem[] orderItems1 = { orderItem1, orderItem2};
            OrderItem[] orderItems2 = { orderItem2, orderItem3};
            OrderItem[] orderItems3 = { orderItem2, orderItem3, orderItem4 };
            OrderItem[] orderItems4 = { orderItem2, orderItem4 };

            Order order1 = new Order(1, client1, orderItems1);
            order1.calculate();
            Order order2 = new Order(2, client2, orderItems2);
            order2.calculate();
            Order order3 = new Order(3, client3, orderItems4);
            order3.calculate();

            OrderService orderService = new OrderService();
            orderService.add(order2);
            orderService.add(order1);
            orderService.add(order3);
            Console.Write("当前保存的订单编号序列: ");
            orderService.showID();
            orderService.modify(3, order3);
            Console.WriteLine();
            Console.Write("默认排序后的订单编号序列: ");
            orderService.sort();
            orderService.showID();
            Console.WriteLine();
            Console.WriteLine("删除订单编号为3的订单");
            orderService.sub(3);
            Console.Write("当前保存的订单编号序列: ");
            orderService.showID();
            Console.WriteLine("\n");
            Console.WriteLine("查询z的订单");
            List<Order> zorders = orderService.querybyClient("z");
            foreach (Order order in zorders)
            {
                Console.WriteLine(order);
            }
            Console.WriteLine("\n");
            Console.WriteLine("查询购买了basketball的订单");
            List<Order> forders = orderService.querybyGoods("basketball");
            foreach (Order order in forders)
            {
                Console.WriteLine(order);
            }
            orderService.Export();
            orderService.Import();
            Console.ReadKey();
        }
    }
}
    

