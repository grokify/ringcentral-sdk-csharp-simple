# Installation using Xamarin iOS

This covers installation of the RingCentral SDK and PubNub dependency for making event subscriptions. Both packages are hosted on NuGet as follows:

* [http://www.nuget.org/packages/RingCentralSDK/](http://www.nuget.org/packages/RingCentralSDK/)
* [http://www.nuget.org/packages/Pubnub/](http://www.nuget.org/packages/Pubnub/)

## Build PubNub Messaging DLL

The following steps will compile the required libraries.

1. clone `github.com/pubnub/c-sharp` repo
1. open `c-sharp/mono-for-android/PubnubMessaging/PubNubMessaging.sln` in Xamarin Studio
1. add Json.NET package (Newtonsoft.Json) from NuGet
1. Build All (&#8984;B)

This builds the following in `c-sharp/monotouch/PubnubMessaging/bin/Debug/`

1. `JsonFx.dll`
1. `Newtonsoft.Json.dll`
1. `PubnubMessaging.dll`
1. `PubnubMessaging.dll.mdb`

## Create New Xamarin iOS Solution with libraries

Perform the following steps to load RingCentral and PubNub

1. Create a new Xamarin Android app, e.g. Android App SOlution
1. Add RingCentral NuGet package from Official NuGet Gallery
1. Add `PubnubMessaging.dll` from previous step
  1. Edit References &gt; .Net Assembly &gt; [Browse]
  1. Add `PubnubMessaging.dll` from above

## Create Your App

1. Add the following:

```
using RingCentral;
using PubnubMessaging;
```

## Notes

1. To run your simulator, you may need to set the target device to an actual device vs `iOS Device`