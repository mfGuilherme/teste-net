
using System.ComponentModel.DataAnnotations;

namespace WebCRUDTESTE.Models
{
  
    public class produto

    {
        
        [Display(Name = "Id") ]
       public int ProdutoId { get; set; }

        [Display(Name = "Descrição")]
        public string DscProduto { get; set; }

        [Display(Name = "Valor Unitário")]
        public float VlrUnitario { get; set; }
    }
}
