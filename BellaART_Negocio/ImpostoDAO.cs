using BellaART_Negocio.Mapeamento;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BellaART_Negocio.DAO
{
    public class ImpostoDAO : Conexao
    {
        public List<Imposto> Listar()
        {
            return banco.Query<Imposto>(
                "SELECT * FROM Impostos ORDER BY Nome"
            ).ToList();
        }

        public Imposto Buscar(int id)
        {
            return banco.Query<Imposto>(
                "SELECT * FROM Impostos WHERE ID = @pID",
                new { pID = id }
            ).SingleOrDefault();
        }

        public Int32 Inserir(Imposto imposto)
        {
            return banco.Query<Int32>(
                "INSERT INTO Impostos (Nome, Percentual, Ativo) VALUES (@Nome, @Percentual, @Ativo) SELECT @@IDENTITY",
                imposto
            ).Single();
        }

        public Int32 Alterar(Imposto imposto)
        {
            var resp = banco.Execute(
                "UPDATE Impostos SET Nome = @Nome, Percentual = @Percentual, Ativo = @Ativo WHERE ID = @ID",
                imposto);
            return resp == 0 ? 0 : imposto.ID;
        }

        public Int32 Salvar(Imposto imposto)
        {
            if (imposto == null || imposto.Nome.Trim().Length == 0)
                return 0;

            if (imposto.ID == 0)
                return Inserir(imposto);
            else
                return Alterar(imposto);
        }

        public bool Excluir(int id)
        {
            try
            {
                return banco.Execute(
                    "DELETE FROM Impostos WHERE ID = @pID",
                    new { pID = id }) == 1;
            }
            catch
            {
                return false;
            }
        }
    }
}
