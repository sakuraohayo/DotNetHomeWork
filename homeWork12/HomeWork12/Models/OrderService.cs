using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace HomeWork12.Models
{
    public class OrderService
    {
        public OrderService()
        {
            this.orders = new List<Order>();
        }
        public List<Order> orders;

        public Order GetOrder(int id)
        {
            return orders.Where(o => o.ID == id).FirstOrDefault();
        }

        public List<Order> SearchOrderByGuest(string guest)
        {
            return orders.Where(o => o.GuestName == guest).OrderBy(o => o.TotalPrice).ToList();
        }

        public List<Order> SearchOrderByGoods(string goods)
        {
            return orders.Where(o => o.orderDetails.Exists(g => g.GoodsName == goods)).
                OrderBy(o => o.TotalPrice).ToList();
        }

        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
            {
                Console.WriteLine("该订单已存在!");
            }
            else
            {
                orders.Add(order);
                Console.WriteLine("已成功添加订单:\n" + order.ToString());
            }
        }

        public bool RemoveOrder(int orderId)
        {
            Order ecpOrder = GetOrder(orderId);
            if (ecpOrder == null)
            {
                Console.WriteLine("您要删除的订单不存在!");
                return false;
            }
            orders.Remove(ecpOrder);
            Console.WriteLine("已成功删除订单:\n" + ecpOrder.ToString());
            return true;
        }

        public bool ChangeOrder(Order newOrder)
        {
            Order oldOrder = GetOrder(newOrder.ID);
            if (oldOrder == null)
            {
                Console.WriteLine("您要修改的订单不存在!");
                return false;
            }
            orders.Remove(oldOrder);
            orders.Add(newOrder);
            Console.WriteLine("已成功修改订单" + newOrder.ID);
            return true;
        }

        public void Sort(Func<Order, Order, int> func)
        {
            orders.Sort((o1, o2) => func(o1, o2));
        }

        public void Sort()
        {
            orders.Sort();
        }

        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, orders);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order => {
                    if (!orders.Contains(order))
                    {
                        orders.Add(order);
                    }
                });
            }
        }
    }
}
