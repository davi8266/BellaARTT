using BellaART_Negocio.Mapeamento;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BellaART_Negocio.DAO
{
    public class VendaDAO : Conexao
    {
        public List<Venda> Listar()
        {
            var vendas = banco.Query<Venda>(
                "SELECT * FROM Vendas ORDER BY DataVenda DESC"
            ).ToList();

            foreach (var v in vendas)
            {
                v.Cliente = new ClienteDAO().Buscar(v.IDCliente);
                v.Imposto = new ImpostoDAO().Buscar(v.IDImposto);
                v.Itens = banco.Query<VendaItem>(
                    "SELECT * FROM VendaItens WHERE IDVenda = @pID",
                    new { pID = v.ID }
                ).ToList();
                foreach (var item in v.Itens)
                    item.Produto = new ProdutoDAO().Buscar(item.IDProduto);
            }

            return vendas;
        }

        public Venda Buscar(int id)
        {
            var venda = banco.Query<Venda>(
                "SELECT * FROM Vendas WHERE ID = @pID",
                new { pID = id }
            ).SingleOrDefault();

            if (venda != null)
            {
                venda.Cliente = new ClienteDAO().Buscar(venda.IDCliente);
                venda.Imposto = new ImpostoDAO().Buscar(venda.IDImposto);
                venda.Itens = banco.Query<VendaItem>(
                    "SELECT * FROM VendaItens WHERE IDVenda = @pID",
                    new { pID = id }
                ).ToList();

                foreach (var item in venda.Itens)
                    item.Produto = new ProdutoDAO().Buscar(item.IDProduto);
            }

            return venda;
        }

        public Int32 Salvar(Venda venda)
        {
            if (venda.ID == 0)
                return Inserir(venda);
            else
                return Alterar(venda);
        }

        private Int32 Inserir(Venda venda)
        {
            var id = banco.Query<Int32>(
                "INSERT INTO Vendas (IDCliente, IDImposto, DataVenda, ValorTotal, Ativo) " +
                "VALUES (@IDCliente, @IDImposto, @DataVenda, @ValorTotal, @Ativo) SELECT @@IDENTITY",
                venda
            ).Single();

            foreach (var item in venda.Itens)
            {
                item.IDVenda = id;
                banco.Execute(
                    "INSERT INTO VendaItens (IDVenda, IDProduto, Quantidade, ValorUnitario, Subtotal) " +
                    "VALUES (@IDVenda, @IDProduto, @Quantidade, @ValorUnitario, @Subtotal)",
                    item);
            }

            return id;
        }

        private Int32 Alterar(Venda venda)
        {
            banco.Execute(
                "UPDATE Vendas SET IDCliente = @IDCliente, IDImposto = @IDImposto, " +
                "ValorTotal = @ValorTotal, Ativo = @Ativo WHERE ID = @ID",
                venda);

            banco.Execute("DELETE FROM VendaItens WHERE IDVenda = @pID", new { pID = venda.ID });

            foreach (var item in venda.Itens)
            {
                item.IDVenda = venda.ID;
                banco.Execute(
                    "INSERT INTO VendaItens (IDVenda, IDProduto, Quantidade, ValorUnitario, Subtotal) " +
                    "VALUES (@IDVenda, @IDProduto, @Quantidade, @ValorUnitario, @Subtotal)",
                    item);
            }

            return venda.ID;
        }

        public bool Excluir(int id)
        {
            try
            {
                banco.Execute("DELETE FROM VendaItens WHERE IDVenda = @pID", new { pID = id });
                return banco.Execute("DELETE FROM Vendas WHERE ID = @pID", new { pID = id }) == 1;
            }
            catch
            {
                return false;
            }
        }
    }
}

