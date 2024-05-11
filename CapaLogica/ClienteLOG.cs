using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ClienteLOG
    {
        ClienteDAL _ClienteDAL;

        public int GuardarCliente(Cliente cliente)
        {
            _ClienteDAL = new ClienteDAL();
            return _ClienteDAL.Guardar(cliente);
        }
    }
}
