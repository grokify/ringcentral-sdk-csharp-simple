# Installation using Xamarin .NET

This covers installation of the RingCentral SDK and PubNub dependency for making event subscriptions. Both packages are hosted on NuGet as follows:

* [http://www.nuget.org/packages/RingCentralSDK/](http://www.nuget.org/packages/RingCentralSDK/)
* [http://www.nuget.org/packages/Pubnub/](http://www.nuget.org/packages/Pubnub/)

## Build PubNub Messaging DLL

The following steps will compile the required libraries.

1. clone the Pubnub C# repo: `clone https://github.com/pubnub/c-sharp`
1. open `c-sharp/mono-for-mac/PubNub-Console/PubNub-Messaging.csproj` in Xamarin Studio
1. add Json.NET package (Newtonsoft.Json) from NuGet
1. remove `PubnubExample.cs` to build a DLL by either removing from project or deleting
1. compile target to library by changing "Project Options > Build > General > Code Generation > Compile Target" to "Library" from "Executable"
1. Build All (⌘B)

This builds the `PubNub-Message.dll` library which will be referenced in the following diectory `c-sharp/mono-for-mac/PubNub-Console/bin/Debug/`. Total files include:

```bash
JsonFx.dll
Newtonsoft.Json.dll
PubNub-Messaging.dll
PubNub-Messaging.dll.config
PubNub-Messaging.dll.mdb
```

## Create New Xamarin .NET Solution

Perform the following steps to use the RingCentral SDK:

1. Create a new Xamarin .NET app, e.g. Console Project
1. Add `RingCentral` package from Official NuGet Gallery
1. Set `System.Net.Http` reference to Local Copy
1. Add `PubNub-Messaging.dll` package by editing `.NET Assembly` and adding the DLL.

Note: Adding `System.Net.Http` as a Local Copy is necessary if you run into a `Could not load File or Assembly` error as discussed [here](https://forums.xamarin.com/discussion/27927/could-not-load-file-or-assembly-system-net-http).

## Create Your App

1. Add the following:

```
using RingCentral;
using PubNubMessaging.Core;
```