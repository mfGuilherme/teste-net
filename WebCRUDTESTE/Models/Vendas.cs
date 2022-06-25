using System.ComponentModel.DataAnnotations;

namespace WebCRUDTESTE.Models
{
    public class Vendas
    {
        [Key]
        [Display(Name = "Id da Venda")]
        public int  VendaId { get; set; }

        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }

        [Display(Name = "Quantidade do produto")]
        public int qtdVenda { get; set; }

        [Display(Name = "Valor Unitário")]
        public int  VlrUnitarioVenda { get; set; }
    
        [Display(Name = "Valor total da Venda")]
        public float  vlrTotalVenda { get; set; }
}
}
