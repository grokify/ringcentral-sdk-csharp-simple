# RingCentral SDK for C# Simple

This package is designed to make the RingCentral SDK for C# simple to use.

# Quickstart Guide

## Initialization

```csharp
using RingCentral;
using RingCentralSimple;
```

## Send an SMS

This can be done simply using the `SendMessage()` method which returns a `RingCentral.SDK.Http.Response` object. This assumes that the `accountId` and `extensionId` are the default ids for the authorized user.

```csharp
var sdk = new RingCentral.SDK.SDK("appKey", "appSecret", "serverUrl", "appName", "appVersion");
var rc = new RingCentralSimple.Client(sdk);
rc.Sdk.GetPlatform().Authorize("username", "extension", "password", true);
var response = rc.SendMessage("+15551112222", "+15553334444", "RingCentral SMS via C#");
```

## Access RingCentral Client

The official [RingCentral C# SDK](https://github.com/ringcentral/ringcentral-csharp) is available via the `Sdk` property.

```csharp
var rc = new RingCentralSimple.Client("appKey", "appSecret", "serverUrl");
var rcsdk = rc.Sdk;
```