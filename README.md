# Meergo .NET SDK

The Meergo .NET SDK lets you send customer event data from your .NET applications to your specified destinations.

## SDK setup requirements

- Set up a Meergo account.
- Set up a .NET source in the dashboard.
- Copy the event write key and the endpoint.

## Using the SDK

```csharp
using Meergo;

var config = new Config().SetEndpoint("<endpoint>");

Analytics.Initialize("<event write key>", config);

Analytics.Client.Track("Efg678Mnu", "Product added to cart", new Dictionary<string, object> {
    { "price", 32.17 },
});

Analytics.Client.Flush();
Analytics.Client.Dispose();
```

## Sending events

Refer to the Meergo events documentation for more information on the supported event types.

## License

The Meergo .NET SDK is released under the [MIT license](License.md).
