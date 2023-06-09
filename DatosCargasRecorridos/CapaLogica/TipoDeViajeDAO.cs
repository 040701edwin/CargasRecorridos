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
    public class TipoDeViajeDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(TipoDeViaje oTipoDeViaje)
        {
            db.TipoDeViajes.Add(oTipoDeViaje);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Modificar(TipoDeViaje oTipoDeViaje)
        {
            db.Entry(oTipoDeViaje).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Eliminar(TipoDeViaje oTipoDeViaje)
        {
            db.TipoDeViajes.Remove(oTipoDeViaje);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public TipoDeViaje Buscar(string pCodigo)
        {
            TipoDeViaje oTipoDeViaje;
            oTipoDeViaje = db.TipoDeViajes.DefaultIfEmpty(null).FirstOrDefault(tv => tv.CodigoTipoViaje.Trim() == pCodigo.Trim()); //tv abreviatura de tipo de viaje
            return (oTipoDeViaje);
        }
        
        //Metodo para listar los datos de la tabla
        public List<TipoDeViaje> Listar()
        {
            return (db.TipoDeViajes.ToList());
        }

    }
}
