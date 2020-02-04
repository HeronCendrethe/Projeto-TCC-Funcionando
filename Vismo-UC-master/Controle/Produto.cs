using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Controle
{
    public class Produto
    {
        //atributos
        private int codigo;
        private string nome;
        private double preco;
        private int qtd;
        private string status;


        //relacionamento
        public Fornecedor fornecedor;
        public Usuario usuario;

        public Produto()
        {
            status = "Habilitado";

            //instânciamento da classe relacionada
            fornecedor = new Fornecedor();
            usuario = new Usuario();
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

        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
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

        //insere um novo produto
        public void Inserir(int x)
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
                        cn.CommandText = "INSERT INTO Produto (nome, preco, qtd, status, codigoFornecedor) " +
                        "VALUES (@nome, @preco, @qtd, @status, @codigoFornecedor)";

                        break;

                    case 2:
                        cn.CommandText = "INSERT INTO Produto (nome, preco, qtd, status, codigoUsuario) " +
                        "VALUES (@nome, @preco, @qtd, @status, @codigoUsuario)";
                        break;

                    case 3:
                        cn.CommandText = "INSERT INTO Produto (nome, preco, status, codigoUsuario) " +
                        "VALUES (@nome, @preco, @status, @codigoUsuario)";
                        break;
                }

                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                cn.Parameters.Add("preco", SqlDbType.Float).Value = preco;
                cn.Parameters.Add("qtd", SqlDbType.Int).Value = qtd;
                cn.Parameters.Add("status", SqlDbType.VarChar).Value = status;
                cn.Parameters.Add("codigoFornecedor", SqlDbType.Int).Value = fornecedor.Codigo;
                cn.Parameters.Add("codigoUsuario", SqlDbType.Int).Value = usuario.Codigo;
                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }

        public bool ChecaNome(int x)
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
                        cn.CommandText = "SELECT t1.nome FROM Produto t1, Fornecedor t2 " +
                        "WHERE t1.nome = @nome AND t2.codigoUsuario = @codigoUsuario AND t1.codigoFornecedor = t2.codigo";
                        cn.Parameters.Add("codigoUsuario", SqlDbType.Int).Value = fornecedor.usuario.Codigo;

                        break;

                    case 2:
                        cn.CommandText = "SELECT nome FROM Produto WHERE nome = @nome AND codigoUsuario = @codigoUsuario " +
                            "AND qtd IS NOT NULL";
                        cn.Parameters.Add("codigoUsuario", SqlDbType.Int).Value = usuario.Codigo;

                        break;

                    case 3:
                        cn.CommandText = "SELECT nome FROM Produto WHERE nome = @nome AND codigoUsuario = @codigoUsuario " +
                        "AND qtd IS NULL";
                        cn.Parameters.Add("codigoUsuario", SqlDbType.Int).Value = usuario.Codigo;

                        break;
                }
               
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

        public DataSet Listar(int x, int y)
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

                        if (y == 1)
                        {
                            cn.CommandText = "SELECT t1.*, t2.nome AS Fornecedor FROM Produto t1, Fornecedor t2 " +
                            "WHERE t1.codigoFornecedor = t2.codigo AND t2.codigoUsuario = @codigoUsuario " +
                            "AND t1.status = @status ORDER BY t1.nome";
                        }
                        else
                        {
                            cn.CommandText = "SELECT t1.*, t2.nome AS Fornecedor FROM Produto t1, Fornecedor t2 " +
                            "WHERE t1.codigoFornecedor = t2.codigo AND t2.codigoUsuario = @codigoUsuario ORDER BY t1.nome";
                        }
                     
                        break;

                    case 2:

                        if (y == 1)
                        {
                            cn.CommandText = "SELECT * FROM Produto WHERE codigoUsuario = @codigoUsuario " +
                            "AND qtd IS NOT NULL AND status = @status ORDER BY nome";
                        }
                        else
                        {
                            cn.CommandText = "SELECT * FROM Produto WHERE codigoUsuario = @codigoUsuario " +
                            "AND qtd IS NOT NULL ORDER BY nome";
                        }
                        
                        break;

                    case 3:

                        if (y == 1)
                        {
                            cn.CommandText = "SELECT * FROM Produto WHERE codigoUsuario = @codigoUsuario " +
                            "AND qtd IS NULL AND status = @status ORDER BY nome";
                        }
                        else
                        {
                            cn.CommandText = "SELECT * FROM Produto WHERE codigoUsuario = @codigoUsuario " +
                            "AND qtd IS NULL ORDER BY nome";
                        }
                       
                        break;
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

        public DataSet ListarNome(int x, int y)
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

                        if (y == 1)
                        {
                            cn.CommandText = "SELECT t1.*, t2.nome AS Fornecedor FROM Produto t1, Fornecedor t2 " +
                            "WHERE LOWER(t1.nome) LIKE LOWER(@nome) " +
                            "AND t1.codigoFornecedor = t2.codigo AND t2.codigoUsuario = @codigoUsuario " +
                            "AND t1.status = @status ORDER BY t1.nome";
                        }
                        else
                        {
                            cn.CommandText = "SELECT t1.*, t2.nome AS Fornecedor FROM Produto t1, Fornecedor t2 " +
                            "WHERE LOWER(t1.nome) LIKE LOWER(@nome) " +
                            "AND t1.codigoFornecedor = t2.codigo AND t2.codigoUsuario = @codigoUsuario ORDER BY t1.nome";
                        }
                       
                        break;

                    case 2:

                        if (y == 1)
                        {
                            cn.CommandText = "SELECT * FROM Produto WHERE LOWER(nome) LIKE LOWER(@nome) " +
                            "AND codigoUsuario = @codigoUsuario AND qtd IS NOT NULL AND status = @status ORDER BY nome";
                        }
                        else
                        {
                            cn.CommandText = "SELECT * FROM Produto WHERE LOWER(nome) LIKE LOWER(@nome) " +
                            "AND codigoUsuario = @codigoUsuario AND qtd IS NOT NULL ORDER BY nome";
                        }
                      
                        break;

                    case 3:

                        if (y == 1)
                        {
                            cn.CommandText = "SELECT * FROM Produto WHERE LOWER(nome) LIKE LOWER(@nome) " +
                            "AND codigoUsuario = @codigoUsuario AND qtd IS NULL AND status = @status ORDER BY nome";
                        }
                        else
                        {
                            cn.CommandText = "SELECT * FROM Produto WHERE LOWER(nome) LIKE LOWER(@nome) " +
                            "AND codigoUsuario = @codigoUsuario AND qtd IS NULL ORDER BY nome";
                        }
     
                        break;

                    case 4:
                        cn.CommandText = "SELECT codigo, nome, preco, qtd FROM Produto WHERE LOWER(nome) LIKE LOWER(@nome) " +
                        "AND status = 'Habilitado' AND codigoUsuario = @codigoUsuario " +
                        "AND codigoFornecedor IS NULL AND qtd IS NOT NULL ORDER BY nome";

                        break;

                    case 5:
                        cn.CommandText = "SELECT t1.codigo, t1.nome, t1.preco, t1.qtd FROM Produto t1, Fornecedor t2 WHERE LOWER(t1.nome) LIKE LOWER(@nome) " +
                        "AND t1.status = 'Habilitado' AND t1.codigoFornecedor = t2.codigo " +
                        "AND t2.codigoUsuario = 1 ORDER BY t1.nome";

                        break;

                    case 6:
                        cn.CommandText = "SELECT codigo, nome, preco, qtd FROM Produto WHERE LOWER(nome) LIKE LOWER(@nome) " +
                        "AND status = 'Habilitado' AND codigoUsuario = @codigoUsuario " +
                        "AND codigoFornecedor IS NULL AND qtd IS NULL ORDER BY nome";

                        break;

                    case 7:
                        cn.CommandText = "SELECT t1.codigo, t1.nome, t1.preco, t1.qtd FROM Produto t1, Fornecedor t2 " +
                        "WHERE t1.codigo = @codigo AND t1.status = 'Habilitado' AND t1.codigoFornecedor = t2.codigo";

                        break;

                    case 8:
                        cn.CommandText = "SELECT codigo, nome, preco, qtd FROM Produto WHERE codigo = @codigo " +
                        "AND status = 'Habilitado' AND codigoUsuario = @codigoUsuario AND qtd IS NULL";

                        break;

                    case 9:
                        cn.CommandText = "SELECT codigo, nome, preco, qtd FROM Produto WHERE codigo = @codigo " +
                        "AND status = 'Habilitado' AND codigoUsuario = @codigoUsuario AND qtd IS NOT NULL";

                        break;
                }

                if (x < 7)
                {
                    cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                }

                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
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
                cn.CommandText = "UPDATE Produto SET status = @status WHERE codigo = @codigo";
                cn.Parameters.Add("status", SqlDbType.VarChar).Value = status;
                cn.Parameters.Add("codigo", SqlDbType.VarChar).Value = codigo;
                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }

        public void GetRegistro(int x)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT * FROM Produto WHERE codigo = @codigo";
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        switch (x)
                        {
                            case 1:
                                nome = reader.GetString(1);
                                preco = reader.GetDouble(2);
                                qtd = reader.GetInt32(3);
                                status = reader.GetString(4);
                                fornecedor.Codigo = reader.GetInt32(5);

                                break;

                            case 2:
                                nome = reader.GetString(1);
                                preco = reader.GetDouble(2);
                                qtd = reader.GetInt32(3);
                                status = reader.GetString(4);

                                break;

                            case 3:
                                nome = reader.GetString(1);
                                preco = reader.GetDouble(2);
                                status = reader.GetString(4);

                                break;
                        } 
                    }
                }
            }
        }

        public void Atualizar(int x)
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
                        cn.CommandText = "UPDATE Produto SET nome = @nome, preco = @preco, qtd = @qtd, " +
                        "codigoFornecedor = @codigoFornecedor WHERE codigo = @codigo";

                        break;

                    case 2:
                        cn.CommandText = "UPDATE Produto SET nome = @nome, preco = @preco, qtd = @qtd " +
                        "WHERE codigo = @codigo";

                        break;

                    case 3:
                        cn.CommandText = "UPDATE Produto SET nome = @nome, preco = @preco " +
                        "WHERE codigo = @codigo";

                        break;
                }

                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                cn.Parameters.Add("preco", SqlDbType.Float).Value = preco;
                cn.Parameters.Add("qtd", SqlDbType.Int).Value = qtd;
                cn.Parameters.Add("codigoFornecedor", SqlDbType.Int).Value = fornecedor.Codigo;
                cn.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }
    }
}
