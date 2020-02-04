using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Controle
{
    public class Pagamento
    {
        private int codigo;
        private double valor;
        private string desc;
        private DateTime prazo;
        private string status;

        public Fornecedor fornecedor;

        public Pagamento()
        {
            fornecedor = new Fornecedor();

            status = "Pendente";
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

        public string Desc
        {
            get
            {
                return desc;
            }
            set
            {
                desc = value;
            }
        }

        public DateTime Prazo
        {
            get
            {
                return prazo;
            }
            set
            {
                prazo = value;
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


        public void Inserir()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO Pagamento VALUES (@valor, @descr, @prazo, @status, @codigoFornecedor)";
                cn.Parameters.Add("valor", SqlDbType.VarChar).Value = valor;
                cn.Parameters.Add("descr", SqlDbType.Text).Value = desc;
                cn.Parameters.Add("prazo", SqlDbType.Date).Value = prazo;
                cn.Parameters.Add("status", SqlDbType.NVarChar).Value = status;
                cn.Parameters.Add("codigoFornecedor", SqlDbType.Int).Value = fornecedor.Codigo;
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

                switch (x)
                {
                    case 1:
                        cn.CommandText = "SELECT t1.*, t2.nome FROM Pagamento t1, Fornecedor t2 WHERE " +
                        "t2.codigoUsuario = @codigoUsuario AND t1.codigoFornecedor = t2.codigo AND t1.status = 'Pendente' " +
                        "ORDER BY t1.prazo";
                        break;

                    case 2:
                        cn.CommandText = "SELECT t1.*, t2.nome FROM Pagamento t1, Fornecedor t2 WHERE " +
                        "t2.codigoUsuario = @codigoUsuario AND t1.codigoFornecedor = t2.codigo AND t1.status = 'Realizado' " +
                        "OR t1.status = 'Realizado com Atraso' ORDER BY t1.prazo";
                        break;

                    case 3:
                        cn.CommandText = "SELECT t1.*, t2.nome FROM Pagamento t1, Fornecedor t2 WHERE " +
                        "t2.codigoUsuario = @codigoUsuario AND t1.codigoFornecedor = t2.codigo AND t1.status = 'Atrasado' " +
                        "ORDER BY t1.prazo";
                        break;

                    case 4:
                        cn.CommandText = "SELECT t1.*, t2.nome FROM Pagamento t1, Fornecedor t2 WHERE " +
                        "t2.codigoUsuario = @codigoUsuario AND t1.codigoFornecedor = t2.codigo AND t1.status = 'Pendente' " +
                        "AND LOWER(t2.nome) LIKE LOWER(@nome) ORDER BY t1.prazo";
                        break;

                    case 5:
                        cn.CommandText = "SELECT t1.*, t2.nome FROM Pagamento t1, Fornecedor t2 WHERE " +
                        "t2.codigoUsuario = @codigoUsuario AND t1.codigoFornecedor = t2.codigo AND t1.status = 'Realizado' " +
                        "OR t1.status = 'Realizado com Atraso' AND LOWER(t2.nome) LIKE LOWER(@nome) ORDER BY t1.prazo";
                        break;

                    case 6:
                        cn.CommandText = "SELECT t1.*, t2.nome FROM Pagamento t1, Fornecedor t2 WHERE " +
                        "t2.codigoUsuario = @codigoUsuario AND t1.codigoFornecedor = t2.codigo AND t1.status = 'Atrasado' " +
                        "AND LOWER(t2.nome) LIKE LOWER(@nome) ORDER BY t1.prazo";
                        break;

                    //case 7:
                    //    cn.CommandText = "SELECT t1.*, t2.nome FROM Pagamento t1, Fornecedor t2 WHERE " +
                    //    "t2.codigoUsuario = @codigoUsuario AND t1.codigoFornecedor = t2.codigo AND t1.status = 'Atrasado' " +
                    //    "AND t1.prazo <= convert(datetime,convert(date,GETDATE(),102)) ORDER BY t1.prazo";
                    //    break;

                    //case 8:
                    //    cn.CommandText = "SELECT t1.*, t2.nome FROM Pagamento t1, Fornecedor t2 WHERE " +
                    //    "t2.codigoUsuario = @codigoUsuario AND t1.codigoFornecedor = t2.codigo AND t1.status = 'Atrasado' " +
                    //    "AND LOWER(t2.nome) LIKE LOWER(@nome) ORDER BY t1.prazo";
                    //    break;

                    //case 9:
                    //    cn.CommandText = "SELECT t1.*, t2.nome FROM Pagamento t1, Fornecedor t2 WHERE " +
                    //    "t2.codigoUsuario = @codigoUsuario AND t1.codigoFornecedor = t2.codigo AND t1.status = 'Atrasado' " +
                    //    "AND LOWER(t2.nome) LIKE LOWER(@nome) ORDER BY t1.prazo";
                    //    break;
                }
               
                cn.Parameters.Add("codigoUsuario", SqlDbType.Int).Value = fornecedor.usuario.Codigo;

                if (x > 3 && x < 7)
                {
                    cn.Parameters.Add("nome", SqlDbType.NVarChar).Value = fornecedor.Nome;
                }
                
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
