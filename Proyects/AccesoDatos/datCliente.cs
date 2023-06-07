using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class datCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCliente _instancia = new datCliente();
        //privado para evitar la instanciación directa
        public static datCliente Instancia
        {
            get { return datCliente._instancia; }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Clientes
        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure; 
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.idCliente = Convert.ToInt32(dr["IdCliente"]);
                    Cli.razonSocial = dr["razonSocial"].ToString();
                    Cli.rucCliente = dr["rucCliente"].ToString();
                    Cli.idTipoCliente = Convert.ToInt32(dr["idTipoCliente"]);
                    Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);
                    Cli.idCiudad = Convert.ToInt32(dr["idCiudad"]);
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    lista.Add(Cli);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        /////////////////////////////////InsertaCliente
        public Boolean InsertarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@razonSocial", Cli.razonSocial);
                cmd.Parameters.AddWithValue("@rucCliente", Cli.rucCliente);
                cmd.Parameters.AddWithValue("@idTipoCliente", Cli.idTipoCliente);
                cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                cmd.Parameters.AddWithValue("@idCiudad", Cli.idCiudad);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inserta = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        //////////////////////////////////EditaCliente
        public Boolean EditarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cmd.Parameters.AddWithValue("@rucCliente", Cli.rucCliente);
                cmd.Parameters.AddWithValue("@razonSocial", Cli.razonSocial);
                cmd.Parameters.AddWithValue("@idTipoCliente", Cli.idTipoCliente);
                cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                cmd.Parameters.AddWithValue("@idCiudad", Cli.idCiudad);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                cn.Open(); int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return edita;
        }

        //deshabilitaCliente
        public Boolean DeshabilitarCliente(entCliente Cli) {
            SqlCommand cmd = null; 
            Boolean delete = false; 
            try { 
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaCliente", cn); 
                cmd.CommandType = CommandType.StoredProcedure; 
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente); 
                cn.Open(); 
                int i = cmd.ExecuteNonQuery(); 
                if (i > 0) {
                    delete = true; 
                } 
            } catch (Exception e) {
                throw e; 
            } finally {
                cmd.Connection.Close(); 
            } 
            return delete; 
        }
        #endregion
    }
}
