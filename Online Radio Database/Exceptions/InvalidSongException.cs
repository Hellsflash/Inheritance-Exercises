using System;

namespace Online_Radio_Database.Exceptions
{
    internal class InvalidSongException : Exception
    {
        protected InvalidSongException(string exception) : base(exception)
        {
        }

        public InvalidSongException()
            : this("Invalid song")
        {
        }
    }

}
