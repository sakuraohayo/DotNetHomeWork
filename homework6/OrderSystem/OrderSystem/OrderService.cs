using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace OrderSystem
{
    public class OrderService
    {
        public List<Order> _orderList = new List<Order>();
        public List<Order> OrderList { set; get; }
        public OrderService() { }
        public OrderService(List<Order> orders)
        {
            this._orderList = orders;
            OrderList = orders;
        }
        public void sort()                                                 //默认按照订单号排序
        {
            _orderList.Sort((p1, p2) => p1.OrderNum - p2.OrderNum);
        }
        public void add(Order order)                                       //添加订单
        {
            _orderList.Add(order);
        }
        public void sub(int id)                                           //根据订单号删除订单
        {
            int i = -1;
            int j = -1;
            try
            {
                foreach (Order order in _orderList)
                {
                    i++;
                    if (order.OrderNum == id)
                    {
                        j = i;
                    }
                }
                _orderList.RemoveAt(j);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("订单删除失败，请检查输入的订单号!");
            }
        }
        public void modify(int ordernum, Order neworder)                           //根据订单号修改订单
        {
            int i = -1;
            int j = -1;
            try
            {
                foreach (Order order in _orderList)
                {
                    i++;
                    if (order.OrderNum == ordernum)
                    {
                        j = i;
                    }
                }
                _orderList[j] = neworder;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("订单修改失败，请检查输入的订单号!");
            }
        }
        public Order getOrder(int id)                                              //按照订单号查询
        {
            var query = _orderList.Where(o => o.OrderNum == id);
            Order order = (Order)query;
            return order;
        }
        public List<Order> querybyClient(string name)                              //按照客户名查询
        {
            var query = _orderList.Where(o => o.Client.ClientName == name).OrderBy(o => o.Sum);
            return query.ToList();
        }
        public List<Order> querybyGoods(string name)                               //按照商品名查询
        {
            var query = _orderList.Where(o => {
                foreach (OrderItem orderItem in o.OrderItems)
                {
                    if (orderItem.Goods.GoodsName == name)
                    {
                        return true;
                    }
                }
                return false;
            }).OrderBy(o => o.Sum);
            return query.ToList();
        }
        public void showID()                                                       //输出订单编号
        {
            foreach (Order order in _orderList)
            {
                Console.Write(order.OrderNum + " ");
            }
        }
        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("orderlist.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, _orderList);
            }
            Console.WriteLine("\nSerialized as xml");
            Console.WriteLine(File.ReadAllText("orderlist.xml"));
        }
        public void Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("orderlist.xml", FileMode.Open))
            {
                _orderList = (List<Order>)xmlSerializer.Deserialize(fs);
                Console.WriteLine("\nDeserialized from orderlist.xml");
            }
        }
    }
}

