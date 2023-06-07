using AccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCiudad
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCiudad _instancia = new logCiudad();
        //privado para evitar la instanciación directa
        public static logCiudad Instancia
        {
            get { return logCiudad._instancia; }
        }
        #endregion singleton
        public List<int> ListarIdCiudad()
        {
            return datCiudad.Instancia.ListarIdCiudad();
        }

        public List<entCiudad> ListarCiudad()
        {
            return datCiudad.Instancia.ListarCiudad();
        }
        public void InsertaCiudad(entCiudad Cli)
        {
            datCiudad.Instancia.InsertarCiudad(Cli);
        }
        public void EditarCiudad(entCiudad Cli)
        {
            datCiudad.Instancia.EditarCiudad(Cli);
        }
        public void DeshabilitarCiudad(entCiudad Cli)
        {
            datCiudad.Instancia.DeshabilitarCiudad(Cli);
        }
    }
}
