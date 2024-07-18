using MudBlazor;
using ScreenSound.Web.Response;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;

namespace ScreenSound.Web.Services;
public class MusicaAPI
{
	private readonly HttpClient _httpClient;

	public MusicaAPI(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}
	public async Task<ICollection<MusicaResponse>?> GetArtistasAsync()
	{
		return await _httpClient.GetFromJsonAsync<ICollection<MusicaResponse>>("musicas");
	}
}
