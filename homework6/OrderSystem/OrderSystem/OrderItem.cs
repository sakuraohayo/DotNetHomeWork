using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderItem//订单明细项
    {
        public Goods _goods;
        public int _goodsNum;
        public OrderItem() { }
        public OrderItem(Goods goods, int goodsNum)
        {
            this._goods = goods;
            Goods = goods;
            this._goodsNum = goodsNum;
            GoodsNum = goodsNum;
        }
        public Goods Goods { set; get; }
        public int GoodsNum { set; get; }
        public override bool Equals(object obj)
        {
            return obj is OrderItem item &&
                   EqualityComparer<Goods>.Default.Equals(_goods, item._goods) &&
                   _goodsNum == item._goodsNum;
        }
        public override int GetHashCode()
        {
            var hashCode = -1839463946;
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(_goods);
            hashCode = hashCode * -1521134295 + _goodsNum.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "\nGoodsname:" + _goods.GoodsName + "\ngoodsNum:" + _goodsNum + "\nGoodsPrice:￥" + _goods.GoodsPrice+"\n";
        }

    }
}

