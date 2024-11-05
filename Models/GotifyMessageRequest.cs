namespace GCScript.Gotify.Models;
public class GotifyMessageRequest {
	public string Title { get; set; } = "";
	public string Message { get; set; } = "";
    public int Priority { get; set; } = 5;
}
