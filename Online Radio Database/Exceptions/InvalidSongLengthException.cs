namespace Online_Radio_Database.Exceptions
{
    internal class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException() :
            base("Invalid song length.")
        {
        }

        protected InvalidSongLengthException(string exception) :
            base(exception)
        {
        }
    }
}
