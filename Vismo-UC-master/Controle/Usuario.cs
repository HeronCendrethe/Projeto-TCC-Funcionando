using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Controle
{
    public class Usuario
    {
        private int codigo;
        private string nome;
        private string email;
        private string senha;
        private string nomePadrao;
        private string senhaPadrao;


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

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                senha = value;
            }
        }

        public string NomePadrao
        {
            get
            {
                return nomePadrao;
            }
            set
            {
                nomePadrao = value;
            }
        }

        public string SenhaPadrao
        {
            get
            {
                return senhaPadrao;
            }
            set
            {
                senhaPadrao = value;
            }
        }


        public void Inserir()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO Usuario VALUES (@nome, @email, @senha, @nomePadrao, @senhaPadrao)";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = email;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = senha;
                cn.Parameters.Add("nomePadrao", SqlDbType.VarChar).Value = nomePadrao;
                cn.Parameters.Add("senhaPadrao", SqlDbType.VarChar).Value = senhaPadrao;
                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }

        public void GetCodigo()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT codigo FROM Usuario WHERE nome = @nome";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        codigo = reader.GetInt32(0);
                    }
                }
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
                cn.CommandText = "SELECT nome FROM Usuario WHERE nome = @nome";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }

                return false;
            }
        }

        public bool ChecaNomePadrao()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT nomePadrao FROM Usuario WHERE nomePadrao = @nomePadrao";
                cn.Parameters.Add("nomePadrao", SqlDbType.VarChar).Value = nomePadrao;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }

                return false;
            }
        }

        public bool ChecaEmail()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT email FROM Usuario WHERE email = @email";
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = email;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }

                return false;
            }
        }

        public bool ConfirmaLogin(string comando)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = comando;
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = email;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = senha;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        codigo = reader.GetInt32(0);
                    }

                    return true;
                }

                return false;
            }
        }

        public void CriaPreferencia()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO Preferencias VALUES ('0', '44', '44', '44', @codigoUsuario)";
                cn.Parameters.Add("codigoUsuario", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }
    }
}
