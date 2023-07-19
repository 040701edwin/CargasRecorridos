using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.GestionUsuario;
using System.Security.Cryptography; //Para encriptar

namespace CapaLogica.GestionUsuario
{
    public class UsuarioDAO
    {
        private GestionContainer db = new GestionContainer();
        private string claveMaestra = "ProgDB2019";

        public bool Agregar(string pUsuario, string pClave)
        {
            Usuario oUsuario = new Usuario();
            oUsuario.NombreDeUsuario = Encriptar(pUsuario.Trim());
            oUsuario.ClaveDeUsuario = Encriptar(pClave.Trim());
            db.Usuarios.Add(oUsuario);
            return (db.SaveChanges() > 0 ? true : false);
        }
        public int Validar(string pUsuario, string pClave)
        {
            string usua =Encriptar(pUsuario.Trim());
            string clv = Encriptar(pClave.Trim());
            Usuario oUsuario = db.Usuarios.DefaultIfEmpty(null).FirstOrDefault(u =>
            u.NombreDeUsuario.Trim() == usua &&
            u.ClaveDeUsuario.Trim() == clv);
            return (oUsuario != null ? oUsuario.Id : 0);
        }
        public string Encriptar(string cadena)
        {
            byte[] arrMaestro;
            byte[] arrCifrar = UTF8Encoding.UTF8.GetBytes(cadena);
            MD5CryptoServiceProvider varMd5 = new MD5CryptoServiceProvider();
            arrMaestro = varMd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(claveMaestra));
            varMd5.Clear();
            //Algoritmo 3 dias
            TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();
            tDes.Key = arrMaestro;
            tDes.Mode = CipherMode.ECB;
            tDes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransformadore = tDes.CreateEncryptor();
            byte[] Resulltado = cTransformadore.TransformFinalBlock(arrCifrar, 0, arrCifrar.Length);
            tDes.Clear();
            return (Convert.ToBase64String(Resulltado, 0, Resulltado.Length));
        }
        public string Desencriptar(string textoEncriptado)
        {
            byte[] arrClave;
            byte[] arrDecifrar = Convert.FromBase64String(textoEncriptado);
            MD5CryptoServiceProvider varMd5 = new MD5CryptoServiceProvider();
            arrClave = varMd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(claveMaestra));
            varMd5.Clear();
            TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();
            tDes.Key = arrClave;
            tDes.Mode = CipherMode.ECB;
            tDes.Padding = PaddingMode.PKCS7;
            ICryptoTransform Transformador = tDes.CreateDecryptor();
            byte[] resultado = Transformador.TransformFinalBlock(arrDecifrar, 0, arrDecifrar.Length);
            tDes.Clear();
            return (UTF8Encoding.UTF8.GetString(resultado));
        }
        //public List<ListaUsuario> Listar()
        //{
        //    var q = (from u in db.Usuarios
        //             select new ListaUsuario { NombreDeUsuario = u.NombreDeUsuario, ClaveDeUsuario = u.ClaveDeUsuario, Id = u.Id }).ToList();
        //    return q;
        //}
        //public bool VerificarPermiso(int idUsuario, int idFuncion)
        //{
        //    var q = (from f in db.FuncionesDeAcceso
        //             join fu in db.FuncionesAsignadas
        //             on f.Id equals fu.FuncionDeAccesoId
        //             where fu.UsuarioId == idUsuario && fu.FuncionDeAccesoId == idFuncion && fu.FechaDeVencimiento >= DateTime.Now
        //             select f).ToList();
        //    return q.Count > 0 ? true : false;
        //}
    }
}
