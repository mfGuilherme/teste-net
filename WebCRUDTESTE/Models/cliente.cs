using System.ComponentModel.DataAnnotations;

namespace WebCRUDTESTE.Models
{
    public class cliente
    {
        [Display(Name = "Id do Cliente")]
        public int ClienteId { get; set; }

        [Display(Name = "Nome")]
        public string NmCliente { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }
    }
}
