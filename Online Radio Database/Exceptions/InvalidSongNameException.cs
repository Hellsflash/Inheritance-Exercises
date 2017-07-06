namespace Online_Radio_Database.Exceptions
{
    internal class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException()
            : base("Song name should be between 3 and 30 symbols.")
        {
        }
    }
}
