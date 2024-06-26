﻿using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;

namespace CapaLogica
{
    public class ProductoLog
    {
        ProductoDAL productodal;

        public int SaveProducto(Producto producto, int id=0,bool actualizacion=false)
        {
            productodal = new ProductoDAL();
            return productodal.GuardarProducto(producto, id, actualizacion);
        }

        public int ActualizarProducto(Producto producto,int id )
        {
            productodal = new ProductoDAL();

            return productodal.GuardarProducto(producto, id, true);
        }
        public List<Producto> ObtenerProductos(bool inactivos=false)
        {
            productodal = new ProductoDAL();
            return productodal.leer(inactivos);
        }

        public List<Producto> LeerProductoPornombre(string nombre,bool inactivos = false)
        {
            productodal = new ProductoDAL();
            return productodal.LeerPorNombre(nombre,inactivos);
        }

        public Producto ObtenerProductoPorId(int codigo)
        {
            productodal = new ProductoDAL();

            return productodal.LeerProducto(codigo);
        }

        public int EliminarProducto(int id)
        {
            productodal = new ProductoDAL();
            return productodal.Eliminar(id);
        }

        public string ObtenerProductoPorNombre(int idProducto)
        {
            productodal= new ProductoDAL();
            return productodal.ObtenerNombreProductoDesdeBD(idProducto);
        }
    }
}
