using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Controle
{
    public class Venda
    {
        private int codigo;
        private DateTime data;
        private double valor;
        private int item;
        private int qtd;

        public Usuario usuario;

        public Venda()
        {
            usuario = new Usuario();
        }

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

        public DateTime Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }

        public int Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }

        public int Qtd
        {
            get
            {
                return qtd;
            }
            set
            {
                qtd = value;
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
                cn.CommandText = "INSERT INTO Venda VALUES (@data, @valor, @codigoUsuario)";
                cn.Parameters.Add("data", SqlDbType.DateTime).Value = data;
                cn.Parameters.Add("valor", SqlDbType.Float).Value = valor;
                cn.Parameters.Add("codigoUsuario", SqlDbType.Int).Value = usuario.Codigo;
                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }

        public void PegaCodigo()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT codigo FROM Venda WHERE data = @data";
                cn.Parameters.Add("data", SqlDbType.DateTime).Value = data;
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

        public void InserirItem()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO Produto_Venda VALUES (@codigoVenda, @codigoProduto, @qtd)";
                cn.Parameters.Add("codigoVenda", SqlDbType.Int).Value = codigo;
                cn.Parameters.Add("codigoProduto", SqlDbType.Int).Value = item;
                cn.Parameters.Add("qtd", SqlDbType.Int).Value = qtd;
                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }

        public DataSet Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "SELECT codigo, data, valor FROM Venda WHERE codigoUsuario = @codigoUsuario " +
                  "ORDER BY data DESC";

                cn.Parameters.Add("codigoUsuario", SqlDbType.VarChar).Value = usuario.Codigo;
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }

        public DataSet ListarCodigo()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "SELECT codigo, data, valor FROM Venda WHERE codigoUsuario = @codigoUsuario " +
                "AND codigo = @codigo";

                cn.Parameters.Add("codigoUsuario", SqlDbType.Int).Value = usuario.Codigo;
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }

        public DataSet ListarData(string data1, string data2)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "SELECT codigo, data, valor FROM Venda WHERE codigoUsuario = @codigoUsuario " +
                "AND data BETWEEN '"+ data1 +"' AND '"+ data2 +"' ORDER BY data DESC";

                cn.Parameters.Add("codigoUsuario", SqlDbType.VarChar).Value = usuario.Codigo;
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }

        public DataSet DetalheVenda()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "SELECT t1.codigoProduto, t2.nome, t2.preco, t1.qtd FROM " +
                "Produto_Venda t1, Produto t2 WHERE t1.codigoProduto = t2.codigo AND t1.codigoVenda = @codigo";

                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cn;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;
            }
        }
    }
}
