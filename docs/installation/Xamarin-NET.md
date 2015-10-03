# Installation using Xamarin .NET

This covers installation of the RingCentral SDK and PubNub dependency for making event subscriptions. Both packages are hosted on NuGet as follows:

* [http://www.nuget.org/packages/RingCentralSDK/](http://www.nuget.org/packages/RingCentralSDK/)
* [http://www.nuget.org/packages/Pubnub/](http://www.nuget.org/packages/Pubnub/)

## Create New Xamarin .NET Solution

Perform the following steps to load RingCentral

1. Create a new Xamarin .NET app, e.g. Console Project
1. Add RingCentral NuGet package from Official NuGet Gallery
1. Set `System.Net.Http` reference to Local Copy

Note: Adding `System.Net.Http` as a Local Copy is necessary if you run into a Could not load File or Assembly error as discussed [here](https://forums.xamarin.com/discussion/27927/could-not-load-file-or-assembly-system-net-http).

## Create Your App

1. Add the following:

```
using RingCentral;
```