using System;

namespace PolymorphismExcersize
{
    public class SqlConnection : DbConnection
    {
       public SqlConnection(string _connectionString,int _timeout = 30) : base(_connectionString,_timeout)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Opening a SqlConnection");
        }
        public override void Close()
        {
            Console.WriteLine("Closing SqlConnection");
        }
    }
}
