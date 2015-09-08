# Installation

## Microsoft Visual Studio Community 2015

### Install RingCentral SDK

1. In the Solution Explorer, right click on the Project and click "Manage NuGet Packages..."
1. Search for "ringcentralsdk" to install RingCentralSDK.
  1. This will install a number of dependencies indluding Newtonsoft.Json. In the Output window for "Package Manager" you should see "Successfully installed 'RingCentralSDK 0.0.29'" ... Now in References, you should see RingCentral and RingCentral.NET40.
1. Install `Pubnub`. Upon successful installation, you should see `Successfully installed 'Pubnub 0.0.0' to...`
  1. Optionally delete `PubnubExample.cs` to prevent the "more than one entry point defined" error.

### Install Dependencies

The Newtonsoft.Json and Pubnub dependencies are automatically installed by Nuget on Visual Studio 2015 for Windows.