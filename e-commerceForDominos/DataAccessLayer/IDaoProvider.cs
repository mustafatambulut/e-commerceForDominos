using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerceForDominos.DataAccessLayer
{
   public interface IDaoProvider<T, V> where T : new()
                                       where V : struct     
    {
        T Create<T>(T t);
        T[] GetAll<T>();
        T GetObjectById(V v);
        void Update(T t);
    }
}
