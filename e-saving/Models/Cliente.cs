namespace e_saving.Models 
{

public class Cliente 
    {
        public string CpfCliente {get; set;}
        
        public string NomeCliente {get; set;}
        
        public string SenhaCliente {get; set;}

        public string EmailCliente {get; set;}

        public byte[] ItensDescartados {get; set;} // cabível alterações

        public int PontosCliente {get; set;}

        public string PontoFavoritoCliente {get; set;}
        
    }

}