using GCScript.Gotify.Models;
using System.Net.Http.Json;

namespace GCScript.Gotify;
public class Gotify(string url) {
	public async Task<GotifyMessageResponse?> SendMessage(string token, GotifyMessageRequest message) {
		url = $"{url.TrimEnd('/')}/message?token={token}";
		using var client = new HttpClient();
		var request = await client.PostAsJsonAsync(url, message);
		if (!request.IsSuccessStatusCode) {
			throw new Exception($"Failed to send message: {request.StatusCode}");
		}
		return await request.Content.ReadFromJsonAsync<GotifyMessageResponse>();
	}
}
