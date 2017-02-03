using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoX
{
    class Set<T> : IEnumerable
    {
        public List<T> data { get; set; }

        public Set()
        {
            data = new List<T>();
        }

        public void Add(T item)
        {
            if (!data.Contains(item))
                data.Add(item);
        }
        
        public void Remove(T item)
        {
            data.Remove(item);
        }

        public IEnumerator GetEnumerator()
        {
            return data.GetEnumerator();
        }
    }
}
