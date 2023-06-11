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
    public class TipoDeVehiculoDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(TipoDeVehiculo oTipVehiculo)
        {
            db.TipoDeVehiculos.Add(oTipVehiculo);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Modificar(TipoDeVehiculo oTipVehiculo)
        {
            db.Entry(oTipVehiculo).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }
        public TipoDeVehiculo Buscar(string pCodigo)
        {
            TipoDeVehiculo oTipVehiculo;
            oTipVehiculo = db.TipoDeVehiculos.DefaultIfEmpty(null).FirstOrDefault(tp => tp.CodigoTipoVehiculo.Trim() == pCodigo.Trim()); //tp abreviatura de tipo de vehiculo
            return (oTipVehiculo);
        }

        //Metodo para listar los datos de la tabla
        public List<TipoDeVehiculo> Listar()
        {
            return (db.TipoDeVehiculos.ToList());
        }
    }
}
