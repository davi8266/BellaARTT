namespace BellaART_Negocio.Mapeamento
{
    public class Produto
    {
        public int ID { get; set; }
        public int IDCategoria { get; set; }
        public string Nome { get; set; }
        public string SKU { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal CustoUnitario { get; set; }
        public bool Ativo { get; set; }

        public Categoria Categoria { get; set; }
    }
}
