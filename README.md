# RingCentral Simple SDK for C&#35; / .NET

[![NuGet](https://img.shields.io/nuget/v/RingCentralSimple.svg)](https://www.nuget.org/packages/RingCentralSimple/)
[![NuGet](https://img.shields.io/nuget/dt/RingCentralSimple.svg)](https://www.nuget.org/packages/RingCentralSimple/)
[![Docs](https://img.shields.io/badge/docs-readthedocs-blue.svg)](http://ringcentral-sdk-csharp-simple.readthedocs.org/)

This is a simple wrapper around the [RingCentral C# SDK](https://github.com/ringcentral/ringcentral-csharp) to make common API calls easier to access. The RingCentral SDK client object is available via the simple client and can be introduced via a dependency injection.

The code is a very early proof of concept.

## Installation

Via [NuGet](https://www.nuget.org/packages/RingCentralSimple/):

```
PM> Install-Package RingCentral
PM> Install-Package RingCentralSimple
```

## Quickstart

### Initialization

```csharp
using RingCentral;
using RingCentralSimple;
```

### Send an SMS

This can be done simply using the `SendMessage()` method which returns a `RingCentral.SDK.Http.Response` object. This assumes that the `accountId` and `extensionId` are the default ids for the authorized user.

```csharp
var sdk = new RingCentral.SDK.SDK("appKey", "appSecret", "serverUrl", "appName", "appVersion");
var rc = new RingCentralSimple.Client(sdk);
rc.Sdk.GetPlatform().Authorize("username", "extension", "password", true);
// SendMessage takes the following parameters: ("fromNumber", "toNumber", "message")
var response = rc.SendMessage("+15551112222", "+15553334444", "RingCentral SMS via C#");
```

### Access RingCentral Client

The official [RingCentral C# SDK](https://github.com/ringcentral/ringcentral-csharp) is available via the `Sdk` property.

```csharp
var rc = new RingCentralSimple.Client("appKey", "appSecret", "serverUrl");
var rcsdk = rc.Sdk;
```

## License

RingCentral Simple SDK for C# is available under an MIT-style license. See the `LICENSE.txt` file for details.

RingCentral Simple SDK for C# &copy; 2015 by John Wang