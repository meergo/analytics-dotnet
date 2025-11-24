# Developers 🛠️

This file contains information useful for developers working with the Meergo .NET SDK.

## Testing the SDK

To test the SDK:

1. Make sure the .NET runtime and CLI are installed. [Install .NET](https://learn.microsoft.com/en-us/dotnet/core/sdk#how-to-install-the-net-sdk).

1. Run the tests from the root of the repository:

    ```
    dotnet test
    ```

## Running the sample applications

To run a sample application:

1. Make sure the .NET runtime and CLI are installed. [Install .NET](https://learn.microsoft.com/en-us/dotnet/core/sdk#how-to-install-the-net-sdk).

1. Navigate to the directory of the sample application you want to run:

    ```
    cd Samples/Sloth.Basic
    ```

    or

    ```
    cd Samples/Sloth.Enterprise
    ```

1. Set the `writeKey` and `endpoint` environment variables using values from a Meergo .NET source.

1. Run the application:
    ```
    dotnet run
    ```

1. You should see new logged events in the event debugger of the Meergo .NET source.
