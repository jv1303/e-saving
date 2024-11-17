namespace e_saving.Models
{
    public static class RepositorioCliente
    {
        //lista para criação das tabelas -> falta várias funções ainda
        private static List<Cliente> clientes = new List<Cliente>() 
        {
            new Cliente { 
                CpfCliente = "234.567.565-67", 
                NomeCliente = "Osmar o pequeno", 
                SenhaCliente  = "22563412",
                EmailCliente = "Osmarop@gmail.com",
                ItensDescartados = 23,
                FotoPerfilCliente = new byte[0],
                PontosClientes = 1,
                PontoFavoritoCliente = "Latas e Eletronicos"
            },
            new Cliente {
                CpfCliente = "256.547.565-67", 
                NomeCliente = "Bimbo", 
                SenhaCliente  = "22563as12",
                EmailCliente = "Bimbos@gmail.com",
                ItensDescartados = 23,
                FotoPerfilCliente = new byte[0],
                PontosClientes = 1,
                PontoFavoritoCliente = "Sucateador"
            }
        };
        public static IEnumerable<Cliente> enumCliente => clientes; // Cliente = tipo de dado, enumCliente = nome IEnumerable, clientes = lista que ele busca

        public static string AdicionarComprador(Cliente adCliente) 
        {
            //código original, não apagar em caso de necessidade ->  noticia.Id = noticias.Max(n => n.Id) + 1;
            clientes.Add(adCliente);
            return adCliente.CpfCliente;
        }

        public static void RemoverComprador(string CpfCliente) 
        {
            var rmCliente = clientes.FirstOrDefault(n=> n.CpfCliente == CpfCliente);

            if(rmCliente != null)
            {
                clientes.Remove(rmCliente);
            }
        }
    }
};
