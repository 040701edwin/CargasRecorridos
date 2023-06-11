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
    class VehiculoViajeDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(VehiculoViaje oVehiculoViaje)
        {
            db.VehiculoViajes.Add(oVehiculoViaje);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Modificar(VehiculoViaje oVehiculoViaje)
        {
            db.Entry(oVehiculoViaje).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Eliminar(VehiculoViaje oVehiculoViaje)
        {
            db.VehiculoViajes.Remove(oVehiculoViaje);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public VehiculoViaje Buscar(int pCodigo)
        {
            VehiculoViaje oVehiculoViaje;
            oVehiculoViaje = db.VehiculoViajes.DefaultIfEmpty(null).FirstOrDefault(vv => vv.VehiculoId == pCodigo); //vv abreviatura de vehiculo viaje
            return (oVehiculoViaje);
        }
        //Metodo para listar los datos de la tabla
        public List<Vehiculo> Listar()
        {
            return (db.Vehiculos.ToList());
        }
    }
}
