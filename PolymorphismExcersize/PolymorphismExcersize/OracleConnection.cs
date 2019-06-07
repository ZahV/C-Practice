using System;

namespace PolymorphismExcersize
{
    public class OracleConnection : DbConnection
    {
       public OracleConnection(string _connectionString,int _timeOut = 5) : base(_connectionString,_timeOut)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Opening a Oracle Connection");
        }
        public override void Close()
        {
            Console.WriteLine("Closing Oracle Connection");
        }
    }
}
