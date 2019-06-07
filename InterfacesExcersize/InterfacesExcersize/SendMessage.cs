using System;

namespace InterfacesExcersize
{
    public class SendMessage : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("sending a message");
            
        }
    }
    
}
