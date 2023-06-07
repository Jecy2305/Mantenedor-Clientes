using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace AccesoDatos
{
    public class datCiudad
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCiudad _instancia = new datCiudad();
        //privado para evitar la instanciación directa
        public static datCiudad Instancia
        {
            get { return datCiudad._instancia; }
        }
        #endregion singleton
        public List<int> ListarIdCiudad()
        {
            SqlCommand cmd = null;
            List<entCiudad> lista = new List<entCiudad>();
            List<int> idCiudad = new List<int>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCiudad Cli = new entCiudad();
                    Cli.idCiudad = Convert.ToInt32(dr["IdCiudad"]);
                    idCiudad.Add(Cli.idCiudad);
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
            return idCiudad;
        }
        public List<entCiudad> ListarCiudad()
        {
            SqlCommand cmd = null;
            List<entCiudad> lista = new List<entCiudad>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCiudad Cli = new entCiudad();
                    Cli.idCiudad = Convert.ToInt32(dr["IdCiudad"]);
                    Cli.desCiudad = dr["desCiudad"].ToString();
                    Cli.estCiudad = Convert.ToBoolean(dr["estCiudad"]);
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
        public Boolean InsertarCiudad(entCiudad Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desCiudad", Cli.desCiudad);
                cmd.Parameters.AddWithValue("@estCiudad", Cli.estCiudad);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inserta = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        public Boolean EditarCiudad(entCiudad Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCiudad", Cli.idCiudad);
                cmd.Parameters.AddWithValue("@desCiudad", Cli.desCiudad);
                cmd.Parameters.AddWithValue("@estCiudad", Cli.estCiudad);
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
        public Boolean DeshabilitarCiudad(entCiudad Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCiudad", Cli.idCiudad);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
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
            return delete;
        }
    }
}
