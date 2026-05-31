using BellaART_Negocio.Mapeamento;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BellaART_Negocio.DAO
{
    public class UsuarioDAO : Conexao
    {
        public Usuario Login(string login, string senha)
        {
            var usuario = banco.Query<Usuario>(
                "SELECT * FROM Usuarios WHERE Login = @pLogin AND Senha = @pSenha",
                new { pLogin = login.Trim(), pSenha = senha.Trim() }
            ).SingleOrDefault();

            if (usuario != null)
                usuario.Senha = "";

            return usuario;
        }

        public List<Usuario> Listar()
        {
            return banco.Query<Usuario>(
                "SELECT ID, Nome, Cargo, Login, Admin, Ativo FROM Usuarios ORDER BY Nome"
            ).ToList();
        }

        public Usuario Buscar(int id)
        {
            return banco.Query<Usuario>(
                "SELECT * FROM Usuarios WHERE ID = @pID",
                new { pID = id }
            ).SingleOrDefault();
        }

        public Int32 Inserir(Usuario usuario)
        {
            return banco.Query<Int32>(
                "INSERT INTO Usuarios (Nome, Cargo, Login, Senha, Admin, Ativo) " +
                "VALUES (@Nome, @Cargo, @Login, @Senha, @Admin, @Ativo) " +
                "SELECT @@IDENTITY", usuario
            ).Single();
        }

        public Int32 Alterar(Usuario usuario)
        {
            var resp = banco.Execute(
                "UPDATE Usuarios SET Nome = @Nome, Cargo = @Cargo, Login = @Login, " +
                "Senha = @Senha, Admin = @Admin, Ativo = @Ativo WHERE ID = @ID", usuario);

            return resp == 0 ? 0 : usuario.ID;
        }

        public Int32 Salvar(Usuario usuario)
        {
            if (usuario == null || usuario.Nome.Trim().Length == 0)
                return 0;

            if (usuario.ID == 0)
                return Inserir(usuario);
            else
                return Alterar(usuario);
        }

        public bool Excluir(int id)
        {
            try
            {
                return banco.Execute("DELETE FROM Usuarios WHERE ID = @pID", new { pID = id }) == 1;
            }
            catch
            {
                return false;
            }
        }
    }
}
