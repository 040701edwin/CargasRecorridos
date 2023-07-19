using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.GestionUsuario;

namespace CapaLogica.GestionUsuario
{
    public class FuncionesDAO
    {
        private GestionContainer db = new GestionContainer();

        public FuncionDeAcceso Buscar(string pCodigo)
        {
            return db.FuncionesDeAcceso.DefaultIfEmpty(null).FirstOrDefault(f => f.Codigo.Trim() == pCodigo.Trim());
        }
        public bool Agregar(string pCodigo, string pDescripcion)
        {
            FuncionDeAcceso oFuncion = new FuncionDeAcceso();
            oFuncion.Codigo = pCodigo.Trim();
            oFuncion.Descripcion = pDescripcion.Trim();
            db.FuncionesDeAcceso.Add(oFuncion);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Modificar(string pCodigo, string pDescripcion)
        {
            FuncionDeAcceso oFuncion = Buscar(pCodigo);
            oFuncion.Descripcion = pDescripcion.Trim();
            db.Entry(oFuncion).State = System.Data.Entity.EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Eliminar(string pCodigo, string pDescripcion)
        {
            FuncionDeAcceso oFuncion = Buscar(pCodigo);
            if(oFuncion == null)
            { return (false); }
            db.FuncionesDeAcceso.Remove(oFuncion);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public List<FuncionDeAcceso> Listar()
        { return db.FuncionesDeAcceso.ToList(); }
    }
}
