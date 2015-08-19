using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace RingCentralSimple.Model
{
    public class Base
    {
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

namespace RingCentralSimple.Model
{
    public class Caller
    {
        public string phoneNumber { get; set; }
    }
}

namespace RingCentralSimple.Model.Request
{
    public class SMS : Base
    {
        public Caller from { get; set; }
        public List<Caller> to { get; set; }
        public string text { get; set; }
    }
}
