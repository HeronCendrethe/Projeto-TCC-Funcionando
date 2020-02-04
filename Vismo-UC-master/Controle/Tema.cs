using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Controle
{
    public class Tema
    {
        private string r;
        private string g;
        private string b;

        public Usuario usuario;

        public Tema()
        {
            usuario = new Usuario();
        }

        public string R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }

        public string G
        {
            get
            {
                return g;
            }
            set
            {
                g = value;
            }
        }

        public string B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }


        public void AttCor()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "UPDATE Preferencias SET r = @r, g = @g, b = @b WHERE codigoUsuario = @codigoUsuario";
                cn.Parameters.Add("r", SqlDbType.NVarChar).Value = r;
                cn.Parameters.Add("g", SqlDbType.NVarChar).Value = g;
                cn.Parameters.Add("b", SqlDbType.NVarChar).Value = b;
                cn.Parameters.Add("codigoUsuario", SqlDbType.Int).Value = usuario.Codigo;
                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }

        public void GetCor()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT r, g, b FROM Preferencias WHERE codigoUsuario = @codigoUsuario";
                cn.Parameters.Add("codigoUsuario", SqlDbType.Int).Value = usuario.Codigo;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        r = reader.GetString(0);
                        g = reader.GetString(1);
                        b = reader.GetString(2);
                    }
                }
            }
        }
    }
}
