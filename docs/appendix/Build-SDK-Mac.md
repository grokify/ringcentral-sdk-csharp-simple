# Building the SDK (Mac)

To build the SDK using Xamarin Studio on the Mac, follow these steps:

## Build Xamarin DLLs

### Clone PubNub Repository

```bash
$ git clone https://github.com/pubnub/c-sharp
```

### Build PubNub Libraries

1. Build the PubNub messaging DLL for each of the following: `mono-for-android`, `mono-for-mac`, `monotouch`

## Build RingCentral SDK

### Clone RingCentral SDK Repository

```bash
$ git clone -b develop https://github.com/ringcentral/ringcentral-chsarp
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