using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace e_saving.Models
{

public class Comprador
    {
        [Key]
        [MaxLength(25)]
        public string CnpjComprador {get; set;}

        public byte[] FotoDePerfilComprador {get; set;} // Rever no futuro

        [MaxLength(150)]
        public string EmailComprador {get; set;}

        [MaxLength(30)]
        public string SenhaComprador {get; set;}

        [MaxLength(255)]
        public string RazaoSocial {get; set;}

        //Propriedade de navegação para ContaBanco (Lista)
        //Coleção de ContasBancos associados a este Comprador
        public ICollection<ContaBanco> ContasBancos {get;set;}

        //Propriedade de navegação para Compra (Lista)
        //Coleção de Compra associados a este Comprador
        public ICollection<Compra> Compras { get; set; }
    }
}
