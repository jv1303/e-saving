namespace e_saving.Models 
{

public class Cliente 
    {
        public string CpfCliente {get; set;}
        
        public string NomeCliente {get; set;}
        
        public string SenhaCliente {get; set;}

        public string EmailCliente {get; set;}

        public byte[] ItensDescartados {get; set;} // cabível alterações

<<<<<<< HEAD
        public

=======
        public int PontosCliente {get; set;}

        public string PontoFavoritoCliente {get; set;}
        
>>>>>>> 54b417003eb09ee5818a906d1b565a4688848f4c
    }

}