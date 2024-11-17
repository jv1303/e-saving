namespace e_saving.Models
{

public class Comprador
    {
        public string CnpjComprador {get; set;}

        public byte[] FotoDePerfilComprador {get; set;} // Rever no futuro

        public string EmailComprador {get; set;}

        public string SenhaComprador {get; set;}

        public string RazaoSocial {get; set;}
    }
}
