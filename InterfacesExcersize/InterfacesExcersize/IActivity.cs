using System;

namespace InterfacesExcersize
{
    public class SendPorn : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending your porn directly to your mom. Hope she likes it.");
            
        }
    }

    public interface IActivity
  {

      void Execute();

  }
    
}
