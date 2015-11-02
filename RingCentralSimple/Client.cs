using System;
using System.Collections.Generic;

using RingCentral;
using RingCentral.SDK.Http;

namespace RingCentralSimple
{
    public class Client
    {
        public RingCentral.SDK.SDK Sdk;

        public Client(RingCentral.SDK.SDK ringCentralSdk)
        {
            Sdk = ringCentralSdk;
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
            Response response = Sdk.GetPlatform().Post(request);
            return response;
        }
    }
}
