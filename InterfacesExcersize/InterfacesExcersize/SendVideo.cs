using System;

namespace InterfacesExcersize
{
    public class SendVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending a video");
        }
    }
    
}
