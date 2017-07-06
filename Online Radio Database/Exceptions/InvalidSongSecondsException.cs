namespace Online_Radio_Database.Exceptions
{
    internal class InvalidSongSecondsException : InvalidSongLengthException
    {
        public InvalidSongSecondsException() :
            base("Song seconds should be between 0 and 59.")
        {
        }
    }
}
