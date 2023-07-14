using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Modelo;
using System.Data.Entity;
using CapaDatos.Extensiones;

namespace CapaLogica
{
    public class ProViajeDAO
    {
        private Model1Container db = new Model1Container();

        public List<usp_ObtenerViaje_Result>ObtenerViaje(int ProveedorId)
        {
            return db.usp_ObtenerViaje(ProveedorId).ToList();
        }

        public List<Viaje> Listar()
        {
            return db.Viajes.ToList();
        }//Listar sin parametros

        //public List<ListaViaje> Listar(bool Marcha)
        //{
        //    List<ListaViaje> q;
        //    if (Marcha)
        //    {
        //        q = (from a in db.VehiculoViajes
        //             join b in db.Vehiculos on a.VehiculoId equals b.Id
        //             join c in db.Viajes on a.ViajeId equals c.Id
        //             join d in db.Proveedores on c.ProveedorId equals d.Id
        //             join e in db.Choferes on c.ChoferId equals e.Id
        //             join f in db.TipoDeViajes on c.TipoDeViajeId equals f.Id
        //             join i in db.TipoDeVehiculos on b.TipoDeVehiculoId equals i.Id
        //             join g in db.Paises on c.PaisId equals g.Id
        //             join h in db.Paises on c.PaisId1 equals h.Id
        //             //where a.FechaHoraLlegada.Year == 1900
        //             select new ListaViaje { ViajeId = c.Id, Codigo = c.CodigoViaje }).Distinct().ToList();
        //    }
        //    else
        //    {
        //        q = (from c in db.Viajes
        //             join d in db.Proveedores on c.ProveedorId equals d.Id
        //             join e in db.Choferes on c.ChoferId equals e.Id
        //             join f in db.TipoDeViajes on c.TipoDeViajeId equals f.Id
        //             join g in db.Paises on c.PaisId equals g.Id
        //             join h in db.Paises on c.PaisId1 equals h.Id
        //             //where !(from a in db.VehiculoViajes where a.FechaHoraLlegada.Year == 1900 select c.CodigoViaje).Constains(c.Id)
        //             select new ListaViaje { ViajeId = c.Id, Codigo = c.CodigoViaje }).Distinct().ToList();
        //    }
        //    return q;
        //}
    }
}
