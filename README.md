# Meergo C# SDK

The Meergo C# SDK lets you send customer event data from your .NET applications to your specified destinations.

## SDK setup requirements

- Set up a Meergo account.
- Set up a .NET source in the dashboard.
- Copy the write key and the endpoint.

## Using the SDK

```csharp
using Meergo.Analytics;

var config = new Config()
    .SetEndpoint("YOUR_ENDPOINT");

Analytics.Initialize("YOUR_WRITE_KEY", config);

Analytics.Client.Track("Efg678Mnu", "Product added to cart", new Properties() {
    { "price", 32.17 }
});
```

## Sending events

Refer to the Meergo events documentation for more information on the supported event types.

## License

The Meergo C# SDK is released under the [MIT license](License.md).
