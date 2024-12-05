using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace e_saving.Models 
{

public class Cliente 
    {
        [Key]
        public string CpfCliente {get; set;}
        
        public string NomeCliente {get; set;}
        
        public string SenhaCliente {get; set;}

        public string EmailCliente {get; set;}

        public int ItensDescartados  {get; set;} // cabível alterações

        public byte [] FotoPerfilCliente {get; set;}

        public int PontosClientes {get; set;}

        public string PontoFavoritoCliente {get; set;}
    }

}