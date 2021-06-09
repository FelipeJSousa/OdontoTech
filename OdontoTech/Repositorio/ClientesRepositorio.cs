using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ClientesRepositorio : GenEntityRepo<Clientes>
    {
        public Clientes get(string cpf)
        {
            using (_context = new odontotechEntities())
            {
                return _context.Clientes.FirstOrDefault(x => x.cli_cpf.Replace(".","").Replace("-","").Equals(cpf.Replace(".", "").Replace("-", "")));
            }
        }
    }
}
