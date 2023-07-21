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
    public class ModeloDAO
    {
        Model1Container db = new Model1Container();
        public bool Agregar(ModeloDelVehiculo oModelo)
        {
            db.ModeloDeLosVehiculos.Add(oModelo);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Modificar(ModeloDelVehiculo oModelo)
        {
            db.Entry(oModelo).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Eliminar(ModeloDelVehiculo oModelo)
        {
            db.ModeloDeLosVehiculos.Remove(oModelo);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public ModeloDelVehiculo Buscar(string pCodigo)
        {
            ModeloDelVehiculo oModelo;
            oModelo = db.ModeloDeLosVehiculos.DefaultIfEmpty(null).FirstOrDefault(mo => mo.Modelo.Trim() == pCodigo.Trim()); //mo significa modelo
            return oModelo;
        }
        public List<ModeloDelVehiculo> Listar()
        {
            return (db.ModeloDeLosVehiculos.ToList());
        }
        public List<sup_Modelo_Result> proModelo(string cod)
        {
            return db.sup_Modelo(cod).ToList();
        }
    }
}
