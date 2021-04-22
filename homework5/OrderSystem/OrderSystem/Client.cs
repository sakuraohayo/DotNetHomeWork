using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Client
    {
        public string _clientName { get; set; }
        public Client(string name)
        {
            //设置客户姓名
            this._clientName = name;
            ClientName = name;
        }
        public string ClientName { get; set; }
        public override string ToString()
        {
            return "clientName:" + _clientName;
        }
    }
}
