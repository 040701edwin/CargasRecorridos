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
    class ViajeChoferDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(ViajeChofer oViajeChofer)
        {
            db.ViajeChoferes.Add(oViajeChofer);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Modificar(ViajeChofer oViajeChofer)
        {
            db.Entry(oViajeChofer).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Eliminar(ViajeChofer oViajeChofer)
        {
            db.ViajeChoferes.Remove(oViajeChofer);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public ViajeChofer Buscar(int pCodigo)
        {
            ViajeChofer oViajeChofer;
            oViajeChofer = db.ViajeChoferes.DefaultIfEmpty(null).FirstOrDefault(vc => vc.ChoferId == pCodigo); //vc abreviatura de viajeChofer
            return (oViajeChofer);
        }
        //Metodo para listar los datos de la tabla
        public List<ViajeChofer> Listar()
        {
            return (db.ViajeChoferes.ToList());
        }
    }
}
