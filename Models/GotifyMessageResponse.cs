namespace GCScript.Gotify.Models;

public class GotifyMessageResponse {
	public int Id { get; set; }
	public int Appid { get; set; }
	public string Message { get; set; } = "";
	public string Title { get; set; } = "";
	public int Priority { get; set; }
	public DateTime Date { get; set; }
}
