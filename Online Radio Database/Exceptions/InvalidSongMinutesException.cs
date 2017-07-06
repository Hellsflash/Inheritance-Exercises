namespace Online_Radio_Database.Exceptions
{
    internal class InvalidSongMinutesException : InvalidSongLengthException
    {
        public InvalidSongMinutesException() :
            base("Song minutes should be between 0 and 14.")
        {
        }
    }
}
