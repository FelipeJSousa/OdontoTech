using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IGenEntityRepo<T> where T : class
    {
        T get(int id);
        List<T> getAll();
        void add(T item);
        void delete(T item);
        void edit(T item);
    }
}
