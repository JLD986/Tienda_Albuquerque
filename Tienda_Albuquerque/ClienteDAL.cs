using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClienteDAL
    {
        ContextoBD _db;

        public int Guardar(Cliente cliente, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBD();

            int resultado;

            if (esActualizacion)
            {
                cliente.ClienteId = id;

                _db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = cliente.ClienteId;
            }
            else
            {
                _db.Cliente.Add(cliente);
                _db.SaveChanges();

                resultado = cliente.ClienteId;
            }

            return resultado;
        }


        public Cliente LeerPorId(int id)
        {
            _db = new ContextoBD();

            return _db.Cliente.Find(id);
        }
    }
}
