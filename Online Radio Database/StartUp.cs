using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Radio_Database.Exceptions;
using Online_Radio_Database.Models;
using System.Text.RegularExpressions;

namespace Online_Radio_Database
{
    internal class Program
    {
        private static List<Song> songs;
        private static StringBuilder output;

        static Program()
        {
            output = new StringBuilder();
            songs = new List<Song>();
        }

        private static void Main()
        {
            ReadSongsData();
            GetPlaylistReport(); 

            Console.WriteLine(output.ToString().Trim()); 
        }

        private static void GetPlaylistReport()
        {
            output.AppendLine($"Songs added: {songs.Count}");

            long playlistTotalSeconds = 0;

            foreach (var song in songs)
            {
                string[] songLength = song.Duration.Split(':');

                playlistTotalSeconds += long.Parse(songLength[0]) * 60 + long.Parse(songLength[1]);
            }

            int hours = (int)playlistTotalSeconds / 60 / 60;
            playlistTotalSeconds %= 3600;
            int minutes = (int)playlistTotalSeconds / 60;
            playlistTotalSeconds %= 60;
            int seconds = (int)playlistTotalSeconds;

            output.AppendLine($"Playlist length: {hours}h {minutes}m {seconds}s");
        }

        private static void ReadSongsData()
        {
            int songsCount = int.Parse(Console.ReadLine());
            string pattern = @"^(.+);(.+);(.+)$";

            for (int i = 0; i < songsCount; i++)
            {
                string line = Console.ReadLine();

                try
                {
                    if (Regex.IsMatch(line, pattern))
                    {
                       
                        Match match = Regex.Match(line, pattern);
                        try
                        {
                            Song newSong = new Song(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value);
                            songs.Add(newSong);
                            output.AppendLine("Song added.");
                        }
                        catch (InvalidSongException e)
                        {
                            output.AppendLine(e.Message);
                        }
                    }
                    else
                    {
                       
                        throw new InvalidSongException();
                    }
                }
                catch (InvalidSongException e)
                {
                    output.AppendLine(e.Message);
                }
            }
        }
    }
}
