# RingCentral Simple SDK for C#

This is a simple wrapper around the RingCentral C# SDK to make common API calls easier to access. The RingCentral SDK client object is available via the simple client.

This is a very early proof of concept.

## Installation

For now, add the directory tree to your project via the file system and then add the `Client.cs` and `Model.cs` files to your project via Visual Studio.

## Quickstart

### Send an SMS

`rc.SendMessage()` returns a `RingCentral.Http.Response` object.

```csharp
var rc = new RingCentralSimple.Client("appKey", "appSecret", "serverUrl");
rc.RingCentralClient.GetPlatform().Authenticate("username", "password", "ext", true);
var response = rc.SendMessage("+15551112222", "+15553334444", "RingCentral SMS from C#");
```

### Access RingCentral Client

```csharp
var rc = new RingCentralSimple.Client("appKey", "appSecret", "serverUrl");
var client = rc.RingCentralClient;
```

## License

RingCentral Simple SDK for C# is available under an MIT-style license. See file:LICENSE.txt for details.

RingCentral Simple SDK for C# &copy; 2015 by John Wang