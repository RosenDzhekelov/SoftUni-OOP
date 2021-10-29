using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
   public class RandomList : List<string>
    {
        private readonly List<string> data;

        public RandomList()
        {
            data = new List<string>();
        }
        public string RandomString()
        {
            Random rnd = new Random();
            if (data.Count != 0)
            {
                int index = rnd.Next(data.Count);
                string value = data[index];
                data.RemoveAt(index);
                return value;
            }
            return null;
        }
    }
}
