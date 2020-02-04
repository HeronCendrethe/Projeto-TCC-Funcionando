using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Controle
{
    public class Fornecedor
    {
        //atributos
        private int codigo;
        private string nome;
        private string status;

        public Usuario usuario;

        public Fornecedor()
        {
            usuario = new Usuario();

            status = "Habilitado";
        }

      
        //encapsulamento de atributos da classe
        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }


        //métodos

        //insere um novo fornecedor
        public void Inserir()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO Fornecedor VALUES (@nome, @status, @codigoUsuario)";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                cn.Parameters.Add("status", SqlDbType.VarChar).Value = status;
                cn.Parameters.Add("codigoUsuario", SqlDbType.VarChar).Value = usuario.Codigo;
                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }

        public DataSet Listar(int x)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                if (x == 1)
                {
                    cn.CommandText = "SELECT codigo, nome, status FROM Fornecedor WHERE codigoUsuario = @codigoUsuario " +
                    "AND status = @status ORDER BY nome";
                }
                else
                {
                    cn.CommandText = "SELECT codigo, nome, status FROM Fornecedor WHERE codigoUsuario = @codigoUsuario " +
                    "ORDER BY nome";
                }
               
                cn.Parameters.Add("codigoUsuario", SqlDbType.VarChar).Value = usuario.Codigo;
                cn.Parameters.Add("status", SqlDbType.VarChar).Value = status;
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }

        public DataSet ListarNome(int x)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                if (x == 1)
                {
                    cn.CommandText = "SELECT codigo, nome, status FROM Fornecedor WHERE LOWER(nome) LIKE LOWER(@nome) AND " +
                    "codigoUsuario = @codigoUsuario AND status = @status ORDER BY nome";
                }
                else
                {
                    cn.CommandText = "SELECT codigo, nome, status FROM Fornecedor WHERE WHERE LOWER(nome) LIKE LOWER(@nome) AND " +
                    "codigoUsuario = @codigoUsuario ORDER BY nome";
                }

                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                cn.Parameters.Add("codigoUsuario", SqlDbType.VarChar).Value = usuario.Codigo;
                cn.Parameters.Add("status", SqlDbType.VarChar).Value = status;
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }

        public void AlteraStatus()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "UPDATE Fornecedor SET status = @status WHERE codigo = @codigo";
                cn.Parameters.Add("status", SqlDbType.VarChar).Value = status;
                cn.Parameters.Add("codigo", SqlDbType.VarChar).Value = codigo;
                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }

        public bool ChecaCodigo()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT codigo FROM Fornecedor WHERE codigo = @codigo AND codigoUsuario = @codigoUsuario";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Parameters.Add("codigoUsuario", SqlDbType.Int).Value = usuario.Codigo;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }

                return false;
            }
        }

        public bool ChecaNome()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT nome FROM Fornecedor WHERE nome = @nome";
                cn.Parameters.Add("nome", SqlDbType.NVarChar).Value = nome;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }

                return false;
            }
        }

        public void Atualizar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "UPDATE Fornecedor SET nome = @nome WHERE codigo = @codigo";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }

        public void GetRegistro()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT nome FROM Fornecedor WHERE codigo = @codigo";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nome = reader.GetString(0);
                    }
                }
            }
        }
    }
}
