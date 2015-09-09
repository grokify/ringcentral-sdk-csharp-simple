# RingCentral Simple SDK for C&#35; / .NET

[![NuGet](https://img.shields.io/nuget/v/RingCentralSimple.svg)]()

This is a simple wrapper around the [RingCentral C# SDK](https://github.com/ringcentral/ringcentral-csharp) to make common API calls easier to access. The RingCentral SDK client object is available via the simple client.

This is a very early proof of concept.

## Installation

Via NuGet:

```
Install-Package RingCentralSimple
```

## Quickstart

### Initialization

```csharp
// import RingCentralSimple SDK
using RingCentralSimple;
```

### Send an SMS

`rc.SendMessage()` returns a `RingCentral.SDK.Http.Response` object.

```csharp
var rc = new RingCentralSimple.Client("appKey", "appSecret", "serverUrl");
rc.Sdk.GetPlatform().Authorize("username", "extension", "password", true);
var response = rc.SendMessage("+15551112222", "+15553334444", "RingCentral SMS via C#");
```

### Access RingCentral Client

The RingCentral SDK's client is available via the `RingCentralSdk` property.

```csharp
var rc = new RingCentralSimple.Client("appKey", "appSecret", "serverUrl");
var rcsdk = rc.Sdk;
```

## License

RingCentral Simple SDK for C# is available under an MIT-style license. See the `LICENSE.txt` file for details.

RingCentral Simple SDK for C# &copy; 2015 by John Wang