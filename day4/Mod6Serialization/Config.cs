using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Serialization
{
    [Serializable]
    class Config
    {
        public string IPAddress { set; get; }
        public string UserName { set; get; }
        public string DBServer { set; get; }
        public Config()
        {
            UserName = UserName + "hlhlhlhhll";
        }
    }
}
