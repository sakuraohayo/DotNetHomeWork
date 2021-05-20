using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork11
{
    [Serializable]
    class OrderDetails
    {
        public OrderDetails(string name,double price,int num)
        {
            GoodsName = name;
            Price = price;
            Quantity = num;
        }
        public string GoodsName { set; get; }
        public double Price { set; get; }
        public int Quantity { set; get; }

        public bool Equals(OrderDetails obj)
        {
            if (obj == null) return false;
            return this.GoodsName == obj.GoodsName && this.Price == obj.Price&&this.Quantity==obj.Quantity;
        }

        override public string ToString()
        {
            return $"商品名：{GoodsName} 单价：{Price} 数量：{Quantity}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public double TotalPrice
        {
            get => Price * Quantity;
        }
    }

    [Serializable]
    class Order
    {
        public Order(string name, int id, List<OrderDetails>ordlist)
        {
            this.GuestName = name;
            this.ID = id;
            this.orderDetails = ordlist;
        }
        public string GuestName { set; get; }
        public int ID { set; get; }
        public List<OrderDetails> orderDetails;

        public bool Equals(Order obj)
        {
            if (obj == null) return false;
            return this.GuestName == obj.GuestName && this.ID == obj.ID;
        }

        override public string ToString()
        {
            string order= $"客户名：{GuestName} 订单号：{ID} \n";
            foreach(OrderDetails ord in orderDetails)
            {
                order += ord.ToString()+"\n";
            }
            return order;
        }

        public double TotalPrice
        {
            get => orderDetails.Sum(ord => ord.TotalPrice);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    class OrderService
    {
        public OrderService()
        {
            this.orders = new List<Order>();
        }
        List<Order> orders;

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
            Console.WriteLine("已成功修改订单"+ newOrder.ID);
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

        public void Export(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, Orders);
            }
        }

        public List<Order> Import(string path)
        {
            List<Order> ods = new List<Order>();
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                ods = (List<Order>)xmlSerializer.Deserialize(fs);
                Console.WriteLine("\nDeserialized from s.xml");
                foreach (Order od in ods)
                    Console.WriteLine(od);
            }
            return ods;
        }

    }


    public class DContext : DbContext
    {
        /// <summary>
        /// 添加构造函数,name为config文件中数据库连接字符串的name
        /// </summary>
        public DContext() : base("name=OrderDataBase")
        {
            Database.SetInitializer(
       new DropCreateDatabaseIfModelChanges<DContext>());
        }

        #region 数据集
        public DbSet<Order> Orders { get; set; }

        #endregion  
    }

    class Program
    {
        static void Main(string[] args)
        {
            OrderDetails apple1 = new OrderDetails("苹果", 6.0, 4);
            OrderDetails apple2 = new OrderDetails("苹果", 6.0, 1);
            OrderDetails orange = new OrderDetails("橘子", 2.5, 10);
            OrderDetails pear = new OrderDetails("梨", 4.5, 5);
            OrderDetails jujube = new OrderDetails("枣", 4.0, 20);
            OrderDetails carrot = new OrderDetails("胡萝卜", 2.0, 5);
            Order order1 = new Order("大花猪", 1, new List<OrderDetails> { apple1, orange, jujube });
            Order order2 = new Order("兔子", 2, new List<OrderDetails> { apple2, pear, carrot });
            Order order3 = new Order("懒熊", 3, new List<OrderDetails> { apple1, orange});
            Order order4 = new Order("兔子", 2, new List<OrderDetails> { apple2, pear, jujube, carrot });
            OrderService service = new OrderService();

            service.AddOrder(order1);
            service.AddOrder(order2);
            service.AddOrder(order1);
            service.ChangeOrder(order4);
            List<Order> jujubeOrder = service.SearchOrderByGoods("枣");
            Console.WriteLine("以下是商品中含有 枣 的订单");
            foreach(Order o in jujubeOrder)
            {
                Console.WriteLine(o.ToString());
            }

            Console.ReadKey();
        }
    }
}
