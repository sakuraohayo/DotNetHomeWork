using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Order
    {
        private int _orderNum;//订单编号
        private Client _client;//订单客户
        private OrderItem[] _orderItems;//订单明细
        private double _sum;
        public Order(int orderNum, Client client ,OrderItem[] orderItems)
        {
            this._orderNum = orderNum;
            OrderNum = orderNum;
            this._client = client;
            Client = client;
            this._orderItems = orderItems;
            OrderItems = orderItems;
        }
        public int OrderNum { get; set; }
        public Client Client { get; set; }
        public OrderItem[] OrderItems { get; set; }
        public double Sum { get; set; }

        public void calculate()                                   //计算订单总金额
        {
            foreach (OrderItem orderItem in _orderItems)
            {
                _sum += (orderItem.Goods.GoodsPrice) * (orderItem.GoodsNum);
            }
        }
        public override string ToString()
        {
            StringBuilder details = new StringBuilder();
            foreach (OrderItem orderItem in _orderItems)
            {
                details.Append(orderItem.ToString());
            }
            return "\norderNum:" + _orderNum + "     ClientName:" +   _client.ClientName +  "     Sum:￥" + _sum + details;
        }
        public override bool Equals(object obj)                                                                
        {
            return obj is Order order &&
                   _orderNum == order._orderNum &&
                   EqualityComparer<Client>.Default.Equals(_client, order._client) &&
                   EqualityComparer<OrderItem[]>.Default.Equals(_orderItems, order._orderItems) &&
                   _sum == order._sum;
        }
        public override int GetHashCode()                                                                  
        {
            var hashCode = -1839463946;
            hashCode = hashCode * -1521134295 + _orderNum.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Client>.Default.GetHashCode(_client);
            hashCode = hashCode * -1521134295 + EqualityComparer<OrderItem[]>.Default.GetHashCode(_orderItems);
            hashCode = hashCode * -1521134295 + _sum.GetHashCode();
            return hashCode;
        }
    }
    
}

