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
    public class PaisDAO
    {
        Model1Container db = new Model1Container();
        public bool Agregar(Pais oPais)
        {
            db.Paises.Add(oPais);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public bool Modificar(Pais oPais)
        {
            db.Entry(oPais).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }
        //Metodo para listar los datos de la tabla
        public List<Pais> Listar()
        {
            return (db.Paises.ToList());
        }
        public bool Eliminar(Pais oPais)
        {
            db.Paises.Remove(oPais);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public Pais Buscar(string pCodigo)
        {
            Pais oPais;
            oPais = db.Paises.DefaultIfEmpty(null).FirstOrDefault(pa => pa.CodigoPais.Trim() == pCodigo.Trim()); //pa significa Pais
            return oPais;
        }
    }
}
