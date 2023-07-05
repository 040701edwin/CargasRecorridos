using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Modelo;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace CapaLogica
{
    public class VehiculoDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(Vehiculo oVehiculo)
        {
            db.Vehiculos.Add(oVehiculo);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Modificar(Vehiculo oVehiculo)
        {
            db.Entry(oVehiculo).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Eliminar(Vehiculo oVehiculo)
        {
            db.Vehiculos.Remove(oVehiculo);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public Vehiculo Buscar(string pCodigo)
        {
            Vehiculo oVehiculo;
            oVehiculo = db.Vehiculos.DefaultIfEmpty(null).FirstOrDefault(ph => ph.PlacaVehiculo.Trim() == pCodigo.Trim()); //ph abreviatura plca de vehiculo
            return oVehiculo;
        }
        //Metodo para listar los datos de la tabla
        public List<Vehiculo> Listar()
        {
            return (db.Vehiculos.ToList());
        }
    }
}
