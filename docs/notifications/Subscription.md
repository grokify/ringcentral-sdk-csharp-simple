# Subscription Quickstart

# Quickstart Guide

## Installation

The following is a very simple recipe to get subscriptions working: 

```csharp
using System;

using RingCentral.SDK;
using RingCentral.Subscription;

namespace console.subscribe
{
	class MainClass
	{

		static void ActionOnNotification(object message) {
			var receivedMessage = message.ToString();
			Console.WriteLine (receivedMessage);
		}

		static void ActionOnConnect(object message){
			var receivedMessage = message.ToString();
			Console.WriteLine (receivedMessage);
		}

		static void ActionOnError(object error) {
			var receivedMessage = error.ToString();
			Console.WriteLine (receivedMessage);
		}

		public static void Main (string[] args)
		{
			var key = "myAppKey";
			var sec = "myAppSecret";
			var url = "https://platform.devtest.ringcentral.com";
			var usr = "myUsername";
			var ext = "myExtension";
			var pwd = "myPassword";
			var sdk = new RingCentral.SDK.SDK(key, sec, url, "appName", "appVersion");
			sdk.GetPlatform ().Authorize (usr, ext, pwd, true);

			var sub = new SubscriptionServiceImplementation(){ _platform = sdk.GetPlatform()};
			sub.AddEvent("/restapi/v1.0/account/~/extension/~/presence");

			sub.Subscribe(ActionOnNotification,ActionOnConnect,ActionOnError);

			Console.ReadLine ();
			Console.WriteLine ("Hello World!");
		}
	}
}
```