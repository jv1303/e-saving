using Microsoft.EntityFrameworkCore;

//Contexto, área responsável pela interação com o banco de dados

namespace e_saving.Models 
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }

        public DbSet<Cliente> clientes {get; set;}
        
    }
}