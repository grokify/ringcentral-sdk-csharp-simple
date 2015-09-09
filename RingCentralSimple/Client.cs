using System;
using System.Collections.Generic;

using RingCentral;
using RingCentral.SDK.Http;

using Newtonsoft.Json;

namespace RingCentralSimple
{
    public class Client
    {
        public RingCentral.SDK.SDK RingCentralSdk;

        public Client(string appKey, string appSecret, string serverUrl)
        {
            RingCentralSdk = new RingCentral.SDK.SDK(appKey, appSecret, serverUrl);
        }

        public Client(RingCentral.SDK.SDK ringCentralSdk)
        {
            RingCentralSdk = ringCentralSdk;
        }

        public Response SendMessage(string from, string to, string text)
        {
            RingCentralSimple.Model.Request.SMS srequest = new RingCentralSimple.Model.Request.SMS
            {
                from = new RingCentralSimple.Model.Request.Caller { phoneNumber = from },
                to = new List<RingCentralSimple.Model.Request.Caller>()
                {
                    new RingCentralSimple.Model.Request.Caller { phoneNumber = to }
                },
                text = text
            };
            Request request = new Request("/restapi/v1.0/account/~/extension/~/sms", srequest.ToJson());
            Response response = RingCentralSdk.GetPlatform().Post(request);
            return response;
        }
    }
}
