using System;
using Meergo;
using Sloth.Common;
using Environment = System.Environment;

namespace Sloth.Basic
{
    class Program
    {
        private const int UserJourneys = 500;

        static void Main(string[] args)
        {
            var writeKey = Environment.GetEnvironmentVariable("writeKey");
            var endpoint = Environment.GetEnvironmentVariable("endpoint");

            if (string.IsNullOrWhiteSpace(writeKey)) throw new ArgumentException(nameof(writeKey));
            if (string.IsNullOrWhiteSpace(endpoint)) throw new ArgumentException(nameof(endpoint));

            OnExecute(writeKey, endpoint);
        }

        private static void OnExecute(string writeKey, string endpoint)
        {

            var config = new Config()
                .SetEndpoint(endpoint);

            Analytics.Initialize(writeKey, config);

            Logger.Handlers += Utils.LoggerOnHandlers;

            for (var i = 0; i < UserJourneys; i++)
            {
                Utils.DoJourney();
            }

            // sending all pendant messages
            Analytics.Client.Flush();

            Utils.PrintSummary();

            Analytics.Client.Dispose();
        }

    }
}
