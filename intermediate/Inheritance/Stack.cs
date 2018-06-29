using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Stack
    {
        private List<object> _stack;

        public Stack()
        {
            _stack = new List<object>();
        }
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("A null object was pushed to the stack");
            _stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack == null || _stack.Count == 0)
                throw new InvalidOperationException("There is no stack to pull from");
            var last = _stack.Count - 1;
            var obj = _stack[last];
            _stack.Remove(obj);
            return obj;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}