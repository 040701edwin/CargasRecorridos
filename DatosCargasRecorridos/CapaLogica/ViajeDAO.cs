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
    public class ViajeDAO
    {
        Model1Container db = new Model1Container();
        public bool Agregar(Viaje oViaje)
        {
            db.Viajes.Add(oViaje);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Modificar(Viaje oViaje)
        {
            db.Entry(oViaje).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Eliminar(Viaje oViaje)
        {
            db.Viajes.Remove(oViaje);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public Viaje Buscar(string pCodigo)
        {
            Viaje oViaje;
            oViaje = db.Viajes.DefaultIfEmpty(null).FirstOrDefault(cv => cv.CodigoViaje.Trim() == pCodigo.Trim()); //cv abreviatura de Codigo viaje
            return oViaje;
        }
        public List<Viaje> Listar()
        {
            return (db.Viajes.ToList());
        }
        //Resultado de la busqueda del procedimiento almacenado
        public List<usp_BucarViaje_Result> proBuscarViaje(string codv)
        {
            return db.usp_BucarViaje(codv).ToList();
        }
        public  List<usp_ViajeProveedor_Result> proDetalleProveedor(string cod)
        {
            return db.usp_ViajeProveedor(cod).ToList();
        }
    }
}
