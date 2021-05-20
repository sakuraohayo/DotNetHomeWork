using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork12.Models
{
    [Serializable]
    public class Order
    {
        public Order() { orderDetails = new List<OrderDetails>();}
        public Order(string name, int id, List<OrderDetails> ordlist)
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
            string order = $"客户名：{GuestName} 订单号：{ID} \n";
            foreach (OrderDetails ord in orderDetails)
            {
                order += ord.ToString() + "\n";
            }
            return order;
        }

        public double TotalPrice
        {
            get => orderDetails.Sum(ord => ord.TotalPrice);
        }
    }
}
