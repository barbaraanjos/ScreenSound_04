using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{

	try
	{
		string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
		var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

		//Console.WriteLine(musicas.Count);
		//musicas[1].ExibirDetalhesDaMusica();
		//LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
		//LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
		//LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
		//LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
		//LinqFilter.FiltrarMusicasPorAno(musicas, "2017");
		LinqFilter.FiltrarMusicasTonalidadeCSharp(musicas);

		//var musicasPreferidasDaBarbie = new MusicasPreferidas("Barbie");
		//musicasPreferidasDaBarbie.AdicionarMusicasFavoritas(musicas[1]);
		//musicasPreferidasDaBarbie.AdicionarMusicasFavoritas(musicas[377]);
		//musicasPreferidasDaBarbie.AdicionarMusicasFavoritas(musicas[4]);
		//musicasPreferidasDaBarbie.AdicionarMusicasFavoritas(musicas[6]);
		//musicasPreferidasDaBarbie.AdicionarMusicasFavoritas(musicas[1467]);

		//musicasPreferidasDaBarbie.ExibirMusicasFavoritas();

		//musicasPreferidasDaBarbie.GerarArquivoJson();
	}
	catch (Exception ex)
	{
		Console.WriteLine($"Tivemos um problema: {ex.Message}");
	}

}
