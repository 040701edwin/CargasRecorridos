using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.GestionUsuario;

namespace CapaLogica.GestionUsuario
{
    public class AsignarPermisosDAO
    {
        private GestionContainer db = new GestionContainer();
        public List<FuncionDeAcceso> ListarPermisos()
        {
            return db.FuncionesDeAcceso.ToList();
        }
        public List<Usuario> ListarUsuario()
        {
            return db.Usuarios.ToList();
        }
        public bool Agregar(FuncionAsignada oFuncionAsignada)
        {
            db.FuncionesAsignadas.Add(oFuncionAsignada);
            return (db.SaveChanges() > 0 ? true : false);
        }
    }
}
