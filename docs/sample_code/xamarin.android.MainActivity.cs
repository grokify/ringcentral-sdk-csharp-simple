// Xamarin.Android

using Android.App;
using Android.Widget;
using Android.OS;

using System;
using RingCentral;
using RingCentral.Http;
using RingCentral.Subscription;

namespace android100
{
	[Activity (Label = "android100", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		public void Action(object message) {
			Console.WriteLine (message.ToString ());
		}

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

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

			String jsonSmsString = "{\"from\":{\"phoneNumber\":\"1650111222\"},\"to\":[{\"phoneNumber\":\"+1650111333\"}],\"text\":\"Hello Android\"}";
			Request request = new Request("/restapi/v1.0/account/~/extension/~/sms", jsonSmsString);
			ApiResponse response2 = sdk.Platform.Post(request);

			var subscription = new RingCentral.Subscription.SubscriptionServiceImplementation(){ _platform = sdk.Platform};
			subscription.AddEvent("/restapi/v1.0/account/~/extension/~/presence");
			subscription.AddEvent("/restapi/v1.0/account/~/extension/~/message-store");
			ApiResponse response3 = subscription.Subscribe(Action, Action, Action);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}
	}
}