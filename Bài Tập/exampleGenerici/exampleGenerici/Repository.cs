using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleGenericT
{
    public class Repository<T> where T : class
    {
      private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public IEnumerable<T> GetAll()
        {
            return items;
        }
    }
}
