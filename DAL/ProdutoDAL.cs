using DeMaria.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMaria.DAL
{
    class ProdutoDAL
    {
        private static readonly string connectionString = "Host=localhost;Username=postgres;Password=axpth4;Database=demaria";

        public static Produto Consultar(int produtoId)
        {
            var produto = new Produto();

            using (var dataSource = NpgsqlDataSource.Create(connectionString))
            {
                string comando =
                    $"select produto_id, descricao, preco, estoque " +
                    $"from produto " +
                    $"where produto_id = {produtoId}";

                using (var cmd = dataSource.CreateCommand(comando))
                {
                    cmd.CommandType = CommandType.Text;

                    using (var reader = cmd.ExecuteReader())
                    {
                        reader.Read();

                        if (reader.HasRows)
                        {
                            produto.ProdutoId = (int)reader[0];
                            produto.Descricao = reader[1].ToString();
                            produto.Preco = (decimal)reader[2];
                            produto.Estoque = (int)reader[3];
                        }
                    }
                }
            }

            return produto;
        }

        public static void Excluir(int produtoId)
        {
            using (var dataSource = NpgsqlDataSource.Create(connectionString))
            {
                using (var cmd = dataSource.CreateCommand("produto_excluir"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_produto_id", Value = produtoId });

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Salvar(Produto produto)
        {
            using (var dataSource = NpgsqlDataSource.Create(connectionString))
            {
                if (produto.ProdutoId == 0)
                {
                    using (var cmd = dataSource.CreateCommand("produto_inserir"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_produto_id", Value = null, Direction = ParameterDirection.Output });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_descricao", Value = produto.Descricao });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_preco", Value = produto.Preco });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_estoque", Value = produto.Estoque });

                        cmd.ExecuteNonQuery();

                        produto.ProdutoId = (int)cmd.Parameters[0].Value;
                    }
                }
                else
                {
                    using (var cmd = dataSource.CreateCommand("produto_alterar"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_produto_id", Value = produto.ProdutoId });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_descricao", Value = produto.Descricao });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_preco", Value = produto.Preco });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_estoque", Value = produto.Estoque });

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            var p = Consultar(produto.ProdutoId);

            produto.ProdutoId = p.ProdutoId;
            produto.Descricao = p.Descricao;
            produto.Preco = p.Preco;
            produto.Estoque = p.Estoque;
        }
    }
}
