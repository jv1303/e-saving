namespace e_saving.Models
{
    public static class RepositorioComprador 
    {
        //lista para criação das tabelas -> falta várias funções ainda
        private static List<Comprador> compradores = new List<Comprador>() 
        {
            new Comprador { 
                CnpjComprador = "74.797.967/0001-02", 
                FotoDePerfilComprador = new byte[0], 
                EmailComprador = "Magnos@gmail.com",
                SenhaComprador = "123345",
                RazaoSocial = "Magnos LTDA"
            },
            new Comprador {
                CnpjComprador = "75.796.967/0001-02", 
                FotoDePerfilComprador = new byte[0], 
                EmailComprador = "Magali@gmail.com",
                SenhaComprador = "123345",
                RazaoSocial = "Magali LTDA"
            }
        };
        public static IEnumerable<Comprador> enumCompradores => compradores; // Comprador = tipo de dado, EnumComprador = nome IEnumerable, compradores = lista que ele busca

        public static string AdicionarComprador(Comprador adComprador) 
        {
            //código original, não apagar em caso de necessidade ->  noticia.Id = noticias.Max(n => n.Id) + 1;
            compradores.Add(adComprador);
            return adComprador.CnpjComprador;
        }

        public static void RemoverComprador(string CnpjComprador) 
        {
            var rmComprador = compradores.FirstOrDefault(n=> n.CnpjComprador == CnpjComprador);

            if(rmComprador != null)
            {
                compradores.Remove(rmComprador);
            }
        }
    }
};
