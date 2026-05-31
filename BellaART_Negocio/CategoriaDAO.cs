using BellaART_Negocio.Mapeamento;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BellaART_Negocio.DAO
{
    public class CategoriaDAO : Conexao
    {
        public List<Categoria> Listar()
        {
            return banco.Query<Categoria>(
                "SELECT * FROM Categorias WHERE Ativo = 1 ORDER BY Nome"
            ).ToList();
        }

        public Categoria Buscar(int id)
        {
            return banco.Query<Categoria>(
                "SELECT * FROM Categorias WHERE ID = @pID",
                new { pID = id }
            ).SingleOrDefault();
        }

        public Int32 Inserir(Categoria categoria)
        {
            return banco.Query<Int32>(
                "INSERT INTO Categorias (Nome, Ativo) VALUES (@Nome, @Ativo) SELECT @@IDENTITY",
                categoria
            ).Single();
        }

        public Int32 Alterar(Categoria categoria)
        {
            var resp = banco.Execute(
                "UPDATE Categorias SET Nome = @Nome, Ativo = @Ativo WHERE ID = @ID",
                categoria);
            return resp == 0 ? 0 : categoria.ID;
        }

        public Int32 Salvar(Categoria categoria)
        {
            if (categoria == null || categoria.Nome.Trim().Length == 0)
                return 0;

            if (categoria.ID == 0)
                return Inserir(categoria);
            else
                return Alterar(categoria);
        }

        public bool Excluir(int id)
        {
            try
            {
                return banco.Execute(
                    "DELETE FROM Categorias WHERE ID = @pID",
                    new { pID = id }) == 1;
            }
            catch
            {
                return false;
            }
        }
    }
}
