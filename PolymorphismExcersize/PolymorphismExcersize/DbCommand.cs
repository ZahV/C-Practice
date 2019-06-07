using System;

namespace PolymorphismExcersize
{
    partial class Program
    {
        public class DbCommand
        {
            private DbConnection _typeOfConnection;
            private string _instruction;

            public DbCommand(DbConnection type,string instruction)
            {
                if (string.IsNullOrWhiteSpace(instruction) || string.IsNullOrEmpty(instruction))
                {
                    throw new Exception("Instruction cannot be empty or null");
                }

                _typeOfConnection = type ?? throw new Exception("Connection cannot be null.");
                _instruction = instruction;
            }

            public void Execute()
            {
                _typeOfConnection.Open();
                Console.WriteLine($"Currentlly executing {_instruction} !");
                _typeOfConnection.Close();
            }
        }
    }
}
