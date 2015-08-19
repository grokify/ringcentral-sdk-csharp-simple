using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace RingCentralInfo
{
    public class Base
    {
        public string ToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
    }
}

namespace RingCentralInfo
{
    public class Caller
    {
        public string phoneNumber { get; set; }
    }
}

namespace RingCentralInfo.Request
{
    public class SMS : Base
    {
        public RingCentralInfo.Caller from { get; set; }
        public string text { get; set; }
    }
}
