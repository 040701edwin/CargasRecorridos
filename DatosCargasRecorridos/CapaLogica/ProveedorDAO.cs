using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Modelo;
using System.Data.Entity;

namespace CapaLogica
{
    public class ProveedorDAO
    {
        Model1Container db = new Model1Container();
        public bool Agregar(Proveedor oProveedor)
        {
            db.Proveedores.Add(oProveedor);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Modificar(Proveedor oProveedor)
        {
            db.Entry(oProveedor).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Eliminar(Proveedor oProveedor)
        {
            db.Proveedores.Remove(oProveedor);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public Proveedor Buscar(string pCodigo)
        {
            Proveedor oProveedor;
            oProveedor   = db.Proveedores.DefaultIfEmpty(null).FirstOrDefault(cp => cp.CodigoProveedor.Trim() == pCodigo.Trim()); //cp significa codigo proveedor
            return oProveedor;
        }
    }
}
