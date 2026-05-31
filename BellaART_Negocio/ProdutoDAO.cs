using BellaART_Negocio.Mapeamento;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BellaART_Negocio.DAO
{
    public class ProdutoDAO : Conexao
    {
        public List<Produto> Listar()
        {
            var produtos = banco.Query<Produto>(
                "SELECT * FROM Produtos ORDER BY Nome"
            ).ToList();

            foreach (var p in produtos)
                p.Categoria = new CategoriaDAO().Buscar(p.IDCategoria);

            return produtos;
        }

        public Produto Buscar(int id)
        {
            var produto = banco.Query<Produto>(
                "SELECT * FROM Produtos WHERE ID = @pID",
                new { pID = id }
            ).SingleOrDefault();

            if (produto != null)
                produto.Categoria = new CategoriaDAO().Buscar(produto.IDCategoria);

            return produto;
        }

        public Int32 Inserir(Produto produto)
        {
            return banco.Query<Int32>(
                "INSERT INTO Produtos (IDCategoria, Nome, SKU, Descricao, Quantidade, ValorUnitario, CustoUnitario, Ativo) " +
                "VALUES (@IDCategoria, @Nome, @SKU, @Descricao, @Quantidade, @ValorUnitario, @CustoUnitario, @Ativo) " +
                "SELECT @@IDENTITY", produto
            ).Single();
        }

        public Int32 Alterar(Produto produto)
        {
            var resp = banco.Execute(
                "UPDATE Produtos SET IDCategoria = @IDCategoria, Nome = @Nome, SKU = @SKU, " +
                "Descricao = @Descricao, Quantidade = @Quantidade, ValorUnitario = @ValorUnitario, " +
                "CustoUnitario = @CustoUnitario, Ativo = @Ativo WHERE ID = @ID", produto);

            return resp == 0 ? 0 : produto.ID;
        }

        public Int32 Salvar(Produto produto)
        {
            if (produto == null || produto.Nome.Trim().Length == 0)
                return 0;

            if (produto.ID == 0)
                return Inserir(produto);
            else
                return Alterar(produto);
        }

        public bool Excluir(int id)
        {
            try
            {
                return banco.Execute(
                    "DELETE FROM Produtos WHERE ID = @pID",
                    new { pID = id }) == 1;
            }
            catch
            {
                return false;
            }
        }
    }
}
