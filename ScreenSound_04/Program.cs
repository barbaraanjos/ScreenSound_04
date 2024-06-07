using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{

	try
	{
		string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
		var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        Console.WriteLine(musicas.Count);
		//LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
		//LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
		//LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
		//LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
		LinqFilter.FiltrarMusicasPorAno(musicas, "2017");
    }
	catch (Exception ex)
	{
		Console.WriteLine($"Tivemos um problema: {ex.Message}");
	}

}
