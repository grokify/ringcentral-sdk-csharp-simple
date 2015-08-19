using System;
using System.Collections.Generic;

using RingCentral;
using RingCentral.Http;

namespace RingCentralSimple
{
    public class Client
    {
        public RingCentralClient RingCentralClient;

        public Client(string appKey, string appSecret, string serverUrl)
        {
            RingCentralClient = new RingCentralClient(appKey, appSecret, serverUrl);
        }

        public Response SendMessage(string from, string to, string text)
        {
            RingCentralSimple.Model.Request.SMS req = new RingCentralSimple.Model.Request.SMS
            {
                from = new RingCentralSimple.Model.Caller { phoneNumber = from},
                to = new List<RingCentralSimple.Model.Caller>() { new RingCentralSimple.Model.Caller { phoneNumber = to} },
                text = text
            };
            Request request = new Request("/restapi/v1.0/account/~/extension/~/sms", req.ToJson());
            Response response = RingCentralClient.GetPlatform().PostRequest(request);
            return response;
        }
    }
}