using System;

namespace InheritanceExcersize
{
    partial class Program
    {
        public class Text : PresentationObject
        {
            public int Fontsize { get; set; }
            public string FontName { get; set; }

            public void AddHyperlink(string url)
            {
                Console.WriteLine($"we added a link to {url}");

            }
        }
    }
}
