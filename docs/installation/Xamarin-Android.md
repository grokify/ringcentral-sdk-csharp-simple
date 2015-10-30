# Installation using Xamarin.Android

This covers installation of the RingCentral SDK and PubNub dependency for making event subscriptions. Both packages are hosted on NuGet as follows:

* [http://www.nuget.org/packages/RingCentralSDK/](http://www.nuget.org/packages/RingCentralSDK/)
* [http://www.nuget.org/packages/Pubnub/](http://www.nuget.org/packages/Pubnub/)

## Build PubNub Messaging DLL

The following steps will compile the required libraries.

1. clone `github.com/pubnub/c-sharp` repo
1. open `c-sharp/mono-for-android/PubNubMessaging/PubNubMessaging.csproj` in Xamarin Studio
1. add `Newtonsoft.Json` Json.NET package from NuGet
1. Build All (&#8984;B)

This builds the following in `c-sharp/monotouch/PubnubMessaging/bin/Release/`

```bash
JsonFx.dll
Newtonsoft.Json.dll
PubNubMessaging.dll
PubNubMessaging.dll.mdb
```

## Create New Xamarin Android Solution with libraries

Perform the following steps to load RingCentral and PubNub

1. Create a new Xamarin Android app, e.g. Android App Solution
1. Add `RingCentral` package from Official NuGet Gallery
1. Add `PubNubMessaging.dll` reference by editing `.NET Assembly` and adding the DLL from previous step

## Start Coding

1. Add the following to your code:

```csharp
using RingCentral;
using PubnubMessaging; // if using subscriptions
```