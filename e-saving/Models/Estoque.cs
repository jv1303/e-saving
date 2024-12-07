using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.SignalR;

namespace e_saving.Models 
{

public class Estoque
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEstoque {get; set;}

        public int Quantidade {get; set;}

        //Propriedade de navegação para Compra (Lista)
        //Coleção de Compra associados a este estoque
        public ICollection<Compra> Compras { get; set; }

        public ICollection<Item> Itens { get; set; }

        public ICollection<Funcionario> Funcionarios { get; set; }
    }

}
