using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace RingCentralSimple.Model
{
    public class Base
    {
        public string ToJson()
        {
            return JsonConvert.SerializeObject(
                this,
                Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
            );
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
    public class FaxMeta : Base
    {
        public List<Caller> to { get; set; }
        public string resolution { get; set; }
        public string sendTime { get; set; }
        public string coverIndex { get; set; }
        public string coverPageText { get; set; }
        public string originalMessageId { get; set; }
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
