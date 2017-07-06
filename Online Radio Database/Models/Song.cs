using Online_Radio_Database.Exceptions;

namespace Online_Radio_Database.Models
{
    public class Song
    {
        private string artist;
        private string name;
        private string duration;

        public Song(string artist, string name, string duration)
        {
            this.Artist = artist;
            this.Name = name;
            this.Duration = duration;
        }

        public string Duration
        {
            get { return this.duration; }
            private set
            {
                string[] durationTokens = value.Split(':');
                int minutes = 0;
                int seconds = 0;

                if (!int.TryParse(durationTokens[0], out minutes) || !int.TryParse(durationTokens[1], out seconds))
                {
                    throw new InvalidSongLengthException();
                }
                if (minutes < 0 || minutes > 14)
                {
                    throw new InvalidSongMinutesException();
                }

                if (seconds < 0 || seconds > 59)
                {
                    throw new InvalidSongSecondsException();
                }

                this.duration = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }

                this.name = value;
            }
        }

        public string Artist
        {
            get
            {
                return this.artist;
            }

            private set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }

                this.artist = value;
            }
        }
    }
}

