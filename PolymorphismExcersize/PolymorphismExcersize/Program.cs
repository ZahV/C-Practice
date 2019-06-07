using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExcersize
{
    partial class Program
    {

        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("SQL STRING");
            Console.WriteLine("Value of SqlConnection Timeout: " + sqlConnection._timeOut);
            DbCommand sqlCommand = new DbCommand(sqlConnection, "SQL");
            sqlCommand.Execute();

            OracleConnection oracleConnection = new OracleConnection("ORACLE STRING");
            Console.WriteLine("Value of SqlConnection Timeout: " + oracleConnection._timeOut);
            DbCommand oracleCommand = new DbCommand(oracleConnection, "ORACLE");
            oracleCommand.Execute();
        }
    }
}
