using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Modelo;
using System.Data.Entity; //EntityFramework

namespace CapaLogica
{
    public class ChoferDAO
    {
        Model1Container db = new Model1Container();

        public bool Agregar(Chofer ochof)
        {
            db.Choferes.Add(ochof);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Modificar(Chofer ochof)
        {
            db.Entry(ochof).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Eliminar(Chofer ochof)
        {
            db.Choferes.Remove(ochof);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public Chofer Buscar(string pCodigo)
        {
            Chofer ochof;
            ochof = db.Choferes.DefaultIfEmpty(null).FirstOrDefault(ch => ch.CedulaChofer.Trim() == pCodigo.Trim()); //ch abreviatura de chofer
            return (ochof);
        }
        //Metodo para listar los datos de la tabla
        public List<Chofer> Listar()
        {
            return (db.Choferes.ToList());
        }
    }
}
