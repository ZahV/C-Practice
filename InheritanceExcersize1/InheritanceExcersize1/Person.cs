using System;

namespace InheritanceExcersize1
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            _name = name;
            if (age <= 0)
            {
                throw new Exception("A person cannot be 0 years old.");
            }

            _age = age;
        }
    }
}
