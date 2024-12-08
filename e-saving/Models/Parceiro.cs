using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace e_saving.Models 
{

public class Parceiro
    {
        [MaxLength(30)]
        public string SenhaParceiro {get; set;}
        
        [MaxLength(150)]
        public string EmailParceiro {get; set;}

        [MaxLength(255)]
        public string NomeParceiro {get; set;}

        public byte []? FotoPerfilParceiro {get; set;}

        [Key]
        [MaxLength(25)]
        public string CpfParceiro {get; set;}
        
        public int? PontosParceiro {get; set;}

        [MaxLength(20)]
        public string CepParceiro {get; set;}

        [MaxLength(255)]
        public string LogradouroParceiro {get; set;}
        
        [MaxLength(255)]
        public string? ComplementoParceiro {get; set;}
        
        //Propriedade de navegação para PontoColeta (Lista)
        //Coleção de PontoColeta associados a este Paceiro

        public ICollection<PontoColeta> PontosColeta {get;set;}

        //Propriedade de navegação para ContaBanco (Lista)
        //Coleção de ContaBanco associados a este Paceiro
        public ICollection<ContaBanco> ContasBancos {get;set;}
    }

}