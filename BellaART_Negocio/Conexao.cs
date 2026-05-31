using System.Data.SqlClient;

namespace BellaART_Negocio
{
    public class Conexao
    {
        public SqlConnection banco = null;

        public Conexao()
        {
            banco = new SqlConnection(
                "Data Source=DAWID\\SQLEXPRESS;Initial Catalog=BellaART;Integrated Security=true;"
            );
        }
    }
}
