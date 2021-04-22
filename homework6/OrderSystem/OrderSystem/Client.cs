using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Client
    {
        public string _clientName;
        public Client() { }
        public Client(string name)
        {
            //设置客户姓名
            this._clientName = name;
            ClientName = name;
        }
        public string ClientName { set; get; }
        public override string ToString()
        {
            return "clientName:" + _clientName;
        }
    }
}
