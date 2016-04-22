namespace BringApi.Net
{
    internal class BringConfiguration
    {
        private static string _apiKey;
        internal const int SupportedApiVersion = 3;

        static BringConfiguration()
        {
            ApiVersion = SupportedApiVersion;
        }

        internal static string GetClientUrl()
        {
            return "https://vannsalg.no";
        }

        internal static string GetApiKey()
        {
            if (string.IsNullOrEmpty(_apiKey))
            {
                _apiKey = System.Configuration.ConfigurationManager.AppSettings["PrintNodeApiKey"];
            }

            return _apiKey;
        }

        public static void SetApiKey(string newApiKey)
        {
            _apiKey = newApiKey;
        }

        public static int ApiVersion { get; internal set; }
    }
}
