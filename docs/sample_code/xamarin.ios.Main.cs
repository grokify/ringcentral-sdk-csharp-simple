// Xamarin.iOS

using UIKit;

using System;
using RingCentral;
using RingCentral.Http;
using RingCentral.Subscription;

namespace ios100
{
	public class Application
	{
		public static void Action(object message) {
			Console.WriteLine ("RECEIVED_EVENT");
			Console.WriteLine (message.ToString ());
		}

		// This is the main entry point of the application.
		static void Main (string[] args)
		{

			/* Demo
			 * 
			 * Send SMS and Subscribe
			 *
			 */
			var appKey = "MyAppKey";
			var appSecret = "MyAppSecret";
			var serverUrl = "https://platform.devtest.ringcentral.com";
			var username = "16501112222";
			var extension = "101";
			var password = "MyPassword";

			var sdk = new SDK(appKey, appSecret, serverUrl, "appName", "appVersion");
			ApiResponse response = sdk.Platform.Authorize(username, extension, password, true);

			String jsonSmsString = "{\"from\":{\"phoneNumber\":\"1650111222\"},\"to\":[{\"phoneNumber\":\"+1650111333\"}],\"text\":\"Hello iOS\"}";
			Request request = new Request("/restapi/v1.0/account/~/extension/~/sms", jsonSmsString);
			ApiResponse response2 = sdk.Platform.Post(request);

			var subscription = new RingCentral.Subscription.SubscriptionServiceImplementation(){ _platform = sdk.Platform};
			subscription.AddEvent("/restapi/v1.0/account/~/extension/~/presence");
			subscription.AddEvent("/restapi/v1.0/account/~/extension/~/message-store");
			ApiResponse response3 = subscription.Subscribe(ios100.Application.Action, Action, Action);

			Console.WriteLine (response3.ToString ());

			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}