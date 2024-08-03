using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace TapTrack
{
    internal class SpotifyAPI
    {
        public static string clientId;
        public static string clientSecret;
        public static string accessToken;
        public static string authCode;
        public static string state;
        private static readonly string redirectUri = "http://localhost:1337/callback/";
        private static readonly string authCodeEndpoint = "https://accounts.spotify.com/authorize";
        private static readonly string tokenEndpoint = "https://accounts.spotify.com/api/token";
        private static readonly string currentlyPlayingEndpoint = "https://api.spotify.com/v1/me/player/currently-playing";

        public static void MoveToAuthorizePage()
        {
            state = Guid.NewGuid().ToString();
            string authUrl = $"{authCodeEndpoint}?client_id={clientId}&response_type=code&redirect_uri={HttpUtility.UrlEncode(redirectUri)}&scope=user-read-playback-state user-library-modify&state={state}";

            Process.Start(new ProcessStartInfo { FileName = authUrl, UseShellExecute = true });
        }

        public static async Task<string> GetAccessTokenAsync(string code)
        {
            var client = new HttpClient();

            var requestBody = new StringContent($"grant_type=authorization_code&code={code}&redirect_uri={HttpUtility.UrlEncode(redirectUri)}", Encoding.UTF8, "application/x-www-form-urlencoded");
            var authToken = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

            var response = await client.PostAsync(tokenEndpoint, requestBody);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var jsonDoc = JsonDocument.Parse(responseBody);
            return jsonDoc.RootElement.GetProperty("access_token").GetString();
        }
        public static async Task<string> GetCurrentlyPlayingTrackAsync(string accessToken)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var response = await client.GetAsync(currentlyPlayingEndpoint);
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return null;
            }

            var responseBody = await response.Content.ReadAsStringAsync();
            var jsonDoc = JsonDocument.Parse(responseBody);
            var item = jsonDoc.RootElement.GetProperty("item");
            var trackId = item.GetProperty("id").GetString();

            return trackId;
        }
        public static async Task SaveTrackToLikedSongsAsync(string trackId, string accessToken)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var response = await client.PutAsync($"https://api.spotify.com/v1/me/tracks?ids={trackId}", null);
            response.EnsureSuccessStatusCode();
        }
    }
}
