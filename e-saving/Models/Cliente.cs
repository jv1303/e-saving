using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace e_saving.Models 
{

public class Cliente 
    {
        [Key]
        [MaxLength(25)]
        public string CpfCliente {get; set;}
        
        [MaxLength(255)]
        public string NomeCliente {get; set;}
        
        [MaxLength(30)]
        public string SenhaCliente {get; set;}

        [MaxLength(130)]
        public string EmailCliente {get; set;}

        public int ItensDescartados  {get; set;} // cabível alterações

        public byte [] FotoPerfilCliente {get; set;}

        public int PontosClientes {get; set;}
        
        [MaxLength(25)]
        public string PontoFavoritoCliente {get; set;}

        //Propriedade de navegação para Fornece (Lista)
        //Coleção de Fornece associados a este Cliente
        public ICollection<Fornece> Fornecimentos {get; set;}
        //Propriedade de navegação para ContaBanco (Lista)
        //Coleção de ContasBancos associados a este Cliente
        public ICollection<ContaBanco> ContasBancos {get;set;}
    }

}