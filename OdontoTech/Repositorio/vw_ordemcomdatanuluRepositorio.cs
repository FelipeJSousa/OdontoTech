using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class vw_ordemcomdatanuluRepositorio : GenEntityRepo<vw_ordemcomdatanulu>
    {
        public List<vw_ordemcomdatanulu> procurarCliente(string nomeCliente)
        {
            using (_context = new odontotechEntities())
            {
                return _context.vw_ordemcomdatanulu.Where(x => x.cli_nome.Contains(nomeCliente)).ToList();
            }

        }


    }
}
