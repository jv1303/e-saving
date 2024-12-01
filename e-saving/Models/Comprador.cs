using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace e_saving.Models
{

public class Comprador
    {
        [Key]
        public string CnpjComprador {get; set;}

        public byte[] FotoDePerfilComprador {get; set;} // Rever no futuro

        public string EmailComprador {get; set;}

        public string SenhaComprador {get; set;}

        public string RazaoSocial {get; set;}
    }
}
