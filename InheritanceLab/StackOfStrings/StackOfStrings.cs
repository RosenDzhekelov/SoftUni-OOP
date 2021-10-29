using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
   public  class StackOfStrings : Stack<string>
    {
        private readonly Stack<string> data;
        public StackOfStrings()
        {
            data = new Stack<string>();
        }

        public bool IsEmpty()
        {
            return data.Count == 0;
        }

        public void AddRange(IEnumerable<string> collection)
        {
            foreach (var item in collection)
            {
                data.Push(item);
            }
        }
    }
}
