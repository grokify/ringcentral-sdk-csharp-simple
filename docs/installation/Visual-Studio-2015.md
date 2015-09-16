# Installation using Microsoft Visual Studio 2015

This covers installation of the RingCentral SDK and PubNub dependency for making event subscriptions. Both packages are hosted on NuGet as follows:

* [http://www.nuget.org/packages/RingCentralSDK/](http://www.nuget.org/packages/RingCentralSDK/)
* [http://www.nuget.org/packages/Pubnub/](http://www.nuget.org/packages/Pubnub/)

## Using NuGet Package Manager Console

Use the following command in the [Package Manager Console](http://docs.nuget.org/consume/package-manager-console):

1. `PM> Install-Package RingCentralSDK`
1. `PM> Install-Package Pubnub`

## Using NuGet Package Manager

In the Solution Explorer, right click on the Project and click "Manage NuGet Packages...". Then search and install the following:

1. Search for "RingCentralSDK" to install RingCentralSDK. This will install a number of dependencies indluding Newtonsoft.Json. In the Output window for "Package Manager" you should see "Successfully installed 'RingCentralSDK 0.0.29'" ... Now in References, you should see RingCentral and RingCentral.NET40.
1. Search for "Pubnub" to install the Pubnub dependency. Upon successful installation, you should see `Successfully installed 'Pubnub 0.0.0' to...` Optionally delete `PubnubExample.cs` to prevent the `more than one entry point defined` error.