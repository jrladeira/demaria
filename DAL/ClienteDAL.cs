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
    static class ClienteDAL
    {
        private static readonly string connectionString = "Host=localhost;Username=postgres;Password=axpth4;Database=demaria";

        public static Cliente Consultar(int clienteId)
        {
            var cliente = new Cliente();

            using (var dataSource = NpgsqlDataSource.Create(connectionString))
            {
                string comando =
                    $"select cliente_id, nome, endereco, telefone, email " +
                    $"from cliente " +
                    $"where cliente_id = {clienteId}";

                using (var cmd = dataSource.CreateCommand(comando))
                {
                    cmd.CommandType = CommandType.Text;

                    using (var reader = cmd.ExecuteReader())
                    {
                        reader.Read();

                        if (reader.HasRows)
                        {
                            cliente.ClienteId = (int)reader[0];
                            cliente.Nome = reader[1].ToString();
                            cliente.Endereco = reader[2].ToString();
                            cliente.Telefone = reader[3].ToString();
                            cliente.Email = reader[4].ToString();
                        }
                    }
                }
            }

            return cliente;
        }

        public static void Excluir(int clienteId)
        {
            using (var dataSource = NpgsqlDataSource.Create(connectionString))
            {
                using (var cmd = dataSource.CreateCommand("cliente_excluir"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_cliente_id", Value = clienteId });

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Salvar(Cliente cliente)
        {
            using (var dataSource = NpgsqlDataSource.Create(connectionString))
            {
                if (cliente.ClienteId == 0)
                {
                    using (var cmd = dataSource.CreateCommand("cliente_inserir"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_cliente_id", Value = null, Direction = ParameterDirection.Output });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_nome", Value = cliente.Nome });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_endereco", Value = cliente.Endereco });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_telefone", Value = cliente.Telefone });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_email", Value = cliente.Email });

                        cmd.ExecuteNonQuery();

                        cliente.ClienteId = (int)cmd.Parameters[0].Value;
                    }
                }
                else
                {
                    using (var cmd = dataSource.CreateCommand("cliente_alterar"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_cliente_id", Value = cliente.ClienteId });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_nome", Value = cliente.Nome });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_endereco", Value = cliente.Endereco });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_telefone", Value = cliente.Telefone });
                        cmd.Parameters.Add(new NpgsqlParameter { ParameterName = "p_email", Value = cliente.Email });

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            var c = Consultar(cliente.ClienteId);

            cliente.ClienteId = c.ClienteId;
            cliente.Nome = c.Nome;
            cliente.Endereco = c.Endereco;
            cliente.Telefone = c.Telefone;
            cliente.Email = c.Email;
        }
    }
}
