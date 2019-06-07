using System;

namespace DataStackWithArray
{

    public class Stack<T>
    {
        private T[] _stack;
        private int _count;
      

        public Stack()
        {
            _count = 0;
            _stack = new T[4];
        }

        public void Push(T value)
        {
            if (_count == _stack.Length)
            {   
                T[] array2 = new T[_stack.Length*2];

                for (int i = 0; i < _stack.Length; i++)
                {
                    for (int j = 0; j < array2.Length; j++)
                    {
                        _stack[i] = array2[j];
                    }
                }

                _stack = array2;
               
            }

            _stack[_count] = value;

            _count++;
        }

        public T Pop()
        {
            _count--;
            return _stack[_count];
        }

        public T Peek()
        {
            return _stack[_count -1];
        }

     
    }
}
