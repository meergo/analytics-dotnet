Reference Apps
================

These reference apps are provided as an example of using the Meergo SDK. The folder is structure in the following way:

### `Sloth.Basic`
A sample app which imports the Meergo SDK and exhibits the full functionality exposed without major configuration changes.

### `Sloth.Enterprise`
A sample app which imports the Meergo SDK and exhibits how to configure Meergo SDK to operate at high throughput, operate under proxy service, leverage batching and data compression.

This app demonstrates common configuration changes such as custom queue size, endpoint, and compression.

### `Sloth.Common`
A library of common functionality shared by both reference apps. This is not meant to function as a standalone app.

Usage
=====

Create a new .NET Source (or use an existing one) from within Meergo. Take note of your write key and endpoint.

First, set an environment variable `writeKey` to your source's write key and an environmental variable `endpoint` to your source's endpoint:

```
export writeKey=YOURWRITEKEY
export endpoint=YOURENDPOINT
```

You can run the apps directly on your machine, using [.NET Core 2.1](https://dotnet.microsoft.com/download/dotnet-core/2.1):

```
dotnet run <Project>.csproj
```

**Note:** out of the box, `Sloth.Enterprise` is configured to send data to `https://api.meergo.dev`, which doesn't exist. This is purely done as a demonstration of the endpoint configuration functionality. If you want to see the library working, you can point it to a working endpoint or remove that configuration parameter.