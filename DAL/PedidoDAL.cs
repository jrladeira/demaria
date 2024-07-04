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
    class PedidoDAL
    {
        private static readonly string connectionString = "Host=localhost;Username=postgres;Password=axpth4;Database=demaria";

        public static Pedido Consultar(int pedidoId)
        {
            var pedido = new Pedido();

            using (var dataSource = NpgsqlDataSource.Create(connectionString))
            {
                string comando =
                    $"select p.pedido_id, p.cliente_id, c.nome, p.pedido_data, p.quantidade_total, p.valor_total " +
                    $"from pedido p " +
                    $"inner join cliente c on p.cliente_id = c.cliente_id " +
                    $"where pedido_id = {pedidoId}";

                using (var cmd = dataSource.CreateCommand(comando))
                {
                    cmd.CommandType = CommandType.Text;

                    using (var reader = cmd.ExecuteReader())
                    {
                        reader.Read();

                        if (reader.HasRows)
                        {
                            pedido.PedidoId = (int)reader[0];
                            pedido.ClienteId = (int)reader[1];
                            pedido.Nome = reader[2].ToString();
                            pedido.PedidoData = (DateTime)reader[3];
                            pedido.QuantidadeTotal = (int)reader[4];
                            pedido.ValorTotal = (decimal)reader[5];
                        }
                    }
                }

                if (pedido.PedidoId != 0)
                {
                    comando =
                        $"select i.pedido_item_id, i.pedido_id, i.produto_id, p.descricao, i.quantidade, i.preco, i.valor_total " +
                        $"from pedido_item i " +
                        $"inner join produto p on i.produto_id = p.produto_id " +
                        $"where pedido_id = {pedidoId}";

                    using (var cmd = dataSource.CreateCommand(comando))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                pedido.Itens.Add(new PedidoItem
                                {
                                    PedidoItemId = (int)reader[0],
                                    PedidoId = (int)reader[1],
                                    ProdutoId = (int)reader[2],
                                    Descricao = reader[3].ToString(),
                                    Quantidade = (int)reader[4],
                                    Preco = (decimal)reader[5],
                                    ValorTotal = (decimal)reader[6]
                                });
                            }
                        }
                    }
                }
            }

            return pedido;
        }

        public static void Excluir(int pedidoId)
        {
            using (var dataSource = NpgsqlDataSource.Create(connectionString))
            {
                using (var cmd = dataSource.CreateCommand("pedido_excluir"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_pedido_id", Value = pedidoId });

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Salvar(Pedido pedido)
        {
            using (var dataSource = NpgsqlDataSource.Create(connectionString))
            {
                if (pedido.PedidoId == 0)
                {
                    using (var cmd = dataSource.CreateCommand("pedido_inserir"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_pedido_id", Value = null, Direction = ParameterDirection.Output });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_cliente_id", Value = pedido.ClienteId });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_quantidade_total", Value = pedido.QuantidadeTotal });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_valor_total", Value = pedido.ValorTotal });

                        cmd.ExecuteNonQuery();

                        pedido.PedidoId = (int)cmd.Parameters[0].Value;
                    }
                }
                else
                {
                    using (var cmd = dataSource.CreateCommand("pedido_alterar"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_pedido_id", Value = pedido.PedidoId });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_cliente_id", Value = pedido.ClienteId });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_quantidade_total", Value = pedido.QuantidadeTotal });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_valor_total", Value = pedido.ValorTotal });

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            var p = Consultar(pedido.PedidoId);

            pedido.PedidoId = p.PedidoId;
            pedido.ClienteId = p.ClienteId;
            pedido.Nome = p.Nome;
            pedido.PedidoData = p.PedidoData;
            pedido.QuantidadeTotal = p.QuantidadeTotal;
            pedido.ValorTotal = p.ValorTotal;
        }
    }
}
