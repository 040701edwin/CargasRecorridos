using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica;
using CapaDatos;
using CapaDatos.Modelo;
using System.Data.Entity;

namespace CapaLogica
{
    class MarcaDeVehiculoDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(MarcaVehiculo oMarcaDeVehiculo)
        {
            db.MarcaVehiculos.Add(oMarcaDeVehiculo);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Modificar(MarcaVehiculo oMarcaDeVehiculo)
        {
            db.Entry(oMarcaDeVehiculo).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Eliminar(MarcaVehiculo oMarcaDeVehiculo)
        {
            db.MarcaVehiculos.Remove(oMarcaDeVehiculo);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public MarcaVehiculo Buscar(string pCodigo)
        {
            MarcaVehiculo oMarcaDeVehiculo;
            oMarcaDeVehiculo = db.MarcaVehiculos.DefaultIfEmpty(null).FirstOrDefault(mv => mv.Marca.Trim() == pCodigo.Trim()); //mv abreviatura de marca de vehicullo
            return (oMarcaDeVehiculo);
        }
        //Metodo para listar los datos de la tabla
        public List<MarcaVehiculo> Listar()
        {
            return (db.MarcaVehiculos.ToList());
        }
    }
}
