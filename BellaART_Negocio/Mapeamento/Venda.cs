using System;
using System.Collections.Generic;

namespace BellaART_Negocio.Mapeamento
{
    public class Venda
    {
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public int IDImposto { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Ativo { get; set; }

        public Cliente Cliente { get; set; }
        public Imposto Imposto { get; set; }
        public List<VendaItem> Itens { get; set; } = new List<VendaItem>();
    }

    public class VendaItem
    {
        public int ID { get; set; }
        public int IDVenda { get; set; }
        public int IDProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Subtotal { get; set; }

        public Produto Produto { get; set; }
    }
}
