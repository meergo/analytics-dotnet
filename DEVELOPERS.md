# Developers 🛠️

This file contains information useful for developers working with the Meergo .NET SDK.

## Creating a new release

To create a new release:

1. Update the version references in the repository and commit your changes.
2. Create a new release on Github.

## Publishing a new release

To publish a new release:

1. Make sure you have correctly created the new release (see section above).

2. Make sure you have an API key with "Push" scope on the Meergo organization. You can create one via the NuGet web UI.

3. Navigate to the Analytics directory:

    ```
    cd Analytics
    ```

4. Create the `.nupkg` file for release:
    ```
    dotnet pack --configuration Release
    ```

5. Publish the `.nupkg` file to NuGet:
    ```
    dotnet nuget push bin\Release\Meergo.Analytics.<VERSION>.nupkg --api-key <YOUR_API_KEY> --source https://api.nuget.org/v3/index.json
    ```

## Testing the SDK

To test the SDK:

1. Make sure the .NET runtime and CLI are installed. [Install .NET](https://learn.microsoft.com/en-us/dotnet/core/sdk#how-to-install-the-net-sdk).

2. Run the tests from the root of the repository:

    ```
    dotnet test
    ```

## Running the sample applications

To run a sample application:

1. Make sure the .NET runtime and CLI are installed. [Install .NET](https://learn.microsoft.com/en-us/dotnet/core/sdk#how-to-install-the-net-sdk).

2. Navigate to the directory of the sample application you want to run:

    ```
    cd Samples/Sloth.Basic
    ```

    or

    ```
    cd Samples/Sloth.Enterprise
    ```

3. Set the `writeKey` and `endpoint` environment variables using values from a Meergo .NET source.

4. Run the application:
    ```
    dotnet run
    ```

5. You should see new logged events in the event debugger of the Meergo .NET source.
