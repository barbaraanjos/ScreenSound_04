using ScreenSound_04.Modelos;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
	public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
	{
		var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

		foreach(var genero in todosOsGenerosMusicais)
		{
            Console.WriteLine($"- {genero}");
        }
	}

	public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
	{
		var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical: {genero}");
		foreach(var artista  in artistasPorGeneroMusical)
		{
            Console.WriteLine($"- {artista}");
        }
    }

	public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
	{
		var musicaDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine($"Exibindo as músicas do artista: {nomeDoArtista}");

		foreach (var musica in musicaDoArtista)
		{
			Console.WriteLine($"- {musica.Nome}");
		}
    }

	public static void FiltrarMusicasPorAno(List<Musica> musicas, string ano)
	{
		var anoDaMusica = musicas.Where(musica => musica.Ano!.Equals(ano)).ToList();
		Console.WriteLine($"Exibindo as músicas lançadas em {ano}");

		foreach (var musica in anoDaMusica)
		{
			Console.WriteLine($"- Música: {musica.Nome}, Intérprete: {musica.Artista}");
		}
	}

	public static void FiltrarMusicasTonalidadeCSharp(List<Musica> musicas)
	{
		var tonalidadeDaMusica = musicas.Where(musica => musica.Tonalidade!.Equals("C#")).ToList();
		Console.WriteLine($"Exibindo as músicas com tonalidade C#");

		foreach (var musica in tonalidadeDaMusica)
		{
			Console.WriteLine($"- Música: {musica.Nome}, Intérprete: {musica.Artista}");
		}
	}
}
