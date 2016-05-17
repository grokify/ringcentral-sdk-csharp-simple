// Xamarin.Mac

using System;

using RingCentral;
using RingCentral.Http;

namespace console100
{
	class MainClass
	{
		public static void Action(object message) {
			Console.WriteLine (message.ToString ());
		}

		public static void Main (string[] args)
		{
			var appKey = "MyAppKey";
			var appSecret = "MyAppSecret";
			var serverUrl = "https://platform.devtest.ringcentral.com";
			var username = "16501112222";
			var extension = "101";
			var password = "MyPassword";

			var sdk = new SDK(appKey, appSecret, serverUrl, "appName", "appVersion");
			ApiResponse response = sdk.Platform.Authorize(username, extension, password, true);

			String jsonSmsString = "{\"from\":{\"phoneNumber\":\"1650111222\"},\"to\":[{\"phoneNumber\":\"+1650111333\"}],\"text\":\"Hello Mac\"}";
			Request request = new Request("/restapi/v1.0/account/~/extension/~/sms", jsonSmsString);
			ApiResponse response2 = sdk.Platform.Post(request);

			var subscription = new RingCentral.Subscription.SubscriptionServiceImplementation(){ _platform = sdk.Platform};
			subscription.AddEvent("/restapi/v1.0/account/~/extension/~/presence");
			subscription.AddEvent("/restapi/v1.0/account/~/extension/~/message-store");
			ApiResponse response3 = subscription.Subscribe(Action, Action, Action);

			var wait = Console.ReadLine ();

			Console.WriteLine ("DONE!");
		}
	}
}