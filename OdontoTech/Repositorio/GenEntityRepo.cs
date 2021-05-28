using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repositorio
{
    public class GenEntityRepo<T>: IDisposable, IGenEntityRepo<T> where T : class
    {
        private odontotechEntities _context;

        public T get(int id)
        {
            using (_context = new odontotechEntities())
            {
                return _context.Set<T>().Find(id);
            }
        }

        public List<T> getAll()
        {
            using (_context = new odontotechEntities())
            {
                return _context.Set<T>().ToList();
            }

        }

        public void add(T item)
        {
            try
            {
                using (_context = new odontotechEntities())
                {
                    _context.Set<T>().Add(item);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}","Error to add item");
                throw;
            }
        }

        public void delete(T item)
        {
            using (_context = new odontotechEntities())
            {
                //_context.Set<T>().Remove(item);
                _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public void edit(T item)
        {
            using (_context = new odontotechEntities())
            {
                try
                {
                    _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao Selecionar o Item");
                }
            }

        }

        public void Dispose()
        {
            using (_context = new odontotechEntities())
            {
                _context.Dispose();
            }
        }
    }
}
