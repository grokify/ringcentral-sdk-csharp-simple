# Building the SDK (Mac)

To build the RingCentral SDK using Xamarin Studio on the Mac, follow these steps:

## Build Dependencies

### Build PubNub SDK

#### Clone PubNub Repository

```bash
$ git clone https://github.com/pubnub/c-sharp
```

#### Build PubNub Libraries

1. Build the PubNub messaging DLL for each of the following: [Xamarin.Android](../installation/Xamarin-Android.md), [Xamarin.iOS](../installation/Xamarin-iOS.md), [Xamarin.Mac](../installation/Xamarin-Mac.md)

## Build RingCentral SDK

### Clone RingCentral SDK Repository

```bash
$ git clone -b develop https://github.com/ringcentral/ringcentral-csharp
```

### Build RingCentral Libraries

#### Bootstrap

1. Open `ringcentral-csharp/RingCentral.sln` in Xamarin Studio
1. Add `RingCentral.Android` and `RingCentral.iOS` to Configuration Mappings by navigating to `Solution Options > Build > Configurations > Configuration Mappings` and adding the solution items for the `Release` and / or `Debug` configurations.
1. Close and reopen the solution to remove the alerts.

#### Build RingCentral solution item

1. Build `RingCentral` solution item.

#### Build RingCentral.Android solution item

1. Go to `RingCentral.Android > References` in solution explorer and delete `PubNubMessaging` and `RingCentral` which should have red X's.
1. Add .Net Assembly reference to `PubNubMessaging.dll` for `mono-for-android`
1. Add .Net Assembly reference to `RingCentral.dll` built above
1. Build `RingCentral.Android` solution item

#### Build RingCentral.iOS solution item

1. Go to `RingCentral.iOS > References` in solution explorer and delete `J:\IoS\PubnubMessaging` and `RingCentral` which should have red X's.
1. Add .Net Assembly reference to `PubnubMessaging.dll` for `monotouch` 
1. Add .Net Assembly reference to `RingCentral.dll` built above
1. Build `RingCentral.iOS` solution item

#### Build RingCentral.NET40 solution item

1. Go to `RingCentral.iOS > References` in solution explorer and delete `RingCentral` which should have a red X.
1. Remove `PubnubCore` and `PubnubExample.cs` from project
1. Add .Net Assembly reference to `PubNub-Messaging.dll` for `mono-for-mac`
1. Add .Net Assembly reference to `RingCentral.dll` built above
1. Build `RingCentral.NET40` solution item

#### Build RingCentral.NET40.Test solution item

1. Add .Net Assembly reference to `PubNub-Messaging.dll` for `mono-for-mac`
1. Build `RingCentral.NET40.Test` solution item

#### Build RingCentral solution

1. Build `RingCentral` solution

## Create NuGet Package

Edit and use the `.nuspec` file to create the NuGet package as appropriate. Be sure to use the proper directory forward slashes for Mac.

```bash
$ nuget pack ringcentral.mac.nuspec
```

See the following links for more information on publishing NuGet packages:

1. [Creating and Publishing a Package](https://docs.nuget.org/create/creating-and-publishing-a-package)
1. [Creating NuGet Packages for Xamarin](https://developer.xamarin.com/guides/cross-platform/advanced/nuget/)