using BellaART_Negocio.Mapeamento;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BellaART_Negocio.DAO
{
    public class ClienteDAO : Conexao
    {
        public List<Cliente> Listar()
        {
            return banco.Query<Cliente>(
                "SELECT * FROM Clientes ORDER BY Nome"
            ).ToList();
        }

        public Cliente Buscar(int id)
        {
            return banco.Query<Cliente>(
                "SELECT * FROM Clientes WHERE ID = @pID",
                new { pID = id }
            ).SingleOrDefault();
        }

        public Int32 Inserir(Cliente cliente)
        {
            return banco.Query<Int32>(
                "INSERT INTO Clientes (Nome, CPFCNPJ, Telefone, Email, Endereco, Ativo) " +
                "VALUES (@Nome, @CPFCNPJ, @Telefone, @Email, @Endereco, @Ativo) SELECT @@IDENTITY",
                cliente
            ).Single();
        }

        public Int32 Alterar(Cliente cliente)
        {
            var resp = banco.Execute(
                "UPDATE Clientes SET Nome = @Nome, CPFCNPJ = @CPFCNPJ, Telefone = @Telefone, " +
                "Email = @Email, Endereco = @Endereco, Ativo = @Ativo WHERE ID = @ID",
                cliente);
            return resp == 0 ? 0 : cliente.ID;
        }

        public Int32 Salvar(Cliente cliente)
        {
            if (cliente == null || cliente.Nome.Trim().Length == 0)
                return 0;

            if (cliente.ID == 0)
                return Inserir(cliente);
            else
                return Alterar(cliente);
        }

        public bool Excluir(int id)
        {
            try
            {
                return banco.Execute(
                    "DELETE FROM Clientes WHERE ID = @pID",
                    new { pID = id }) == 1;
            }
            catch
            {
                return false;
            }
        }
    }
}
