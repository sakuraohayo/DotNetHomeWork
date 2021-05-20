using System;
using System.Collections.Generic;

namespace HomeWork12.Models
{
    [Serializable]
    public class OrderDetails
    {
        public OrderDetails() { }
        public OrderDetails(uint index, string name, double price, int num)
        {
            Index = index;
            GoodsName = name;
            Price = price;
            Quantity = num;
        }
        public uint Index { get; set; }
        public string GoodsName { set; get; }
        public double Price { set; get; }
        public int Quantity { set; get; }

        public bool Equals(OrderDetails obj)
        {
            if (obj == null) return false;
            return this.GoodsName == obj.GoodsName && this.Price == obj.Price && this.Quantity == obj.Quantity;
        }

        override public string ToString()
        {
            return $"{Index}商品名：{GoodsName} 单价：{Price} 数量：{Quantity}";
        }

        public double TotalPrice
        {
            get => Price * Quantity;
        }

        public override int GetHashCode()
        {
            var hashCode = -2127770830;
            hashCode = hashCode * -1521134295 + Index.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodsName);
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }
    }
}
