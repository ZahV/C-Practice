using System;

namespace PolymorphismExcersize
{
    public abstract class DbConnection
    {
        public string _connectionString;
        public TimeSpan _timeOut;

        public DbConnection(string connector, int time)
        {
            if (String.IsNullOrEmpty(connector) || string.IsNullOrWhiteSpace(connector))
            {
                throw new Exception("Connector string cannot be null or empty");
            }

            _connectionString = connector;
            _timeOut = TimeSpan.FromSeconds(time);
        }

        public abstract void Close();
        public abstract void Open();

    }
}
