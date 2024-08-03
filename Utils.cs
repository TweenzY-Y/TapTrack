using System;
using System.Web;

namespace TapTrack
{
    internal class Utils
    {
        public static string ExtractAuthCodeFrom(string url)
        {
            var uri = new Uri(url);
            var query = uri.Query;
            var queryDictionary = HttpUtility.ParseQueryString(query);
            var returnedState = queryDictionary["state"];
            if (returnedState != SpotifyAPI.state)
            {
                throw new InvalidOperationException("State mismatch");
            }

            return queryDictionary["code"];
        }
    }
}
