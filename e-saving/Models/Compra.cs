using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.SignalR;

namespace e_saving.Models 
{

//Tabela intermediária entre Comprador e Estoque (relação N:N)
public class Compra 
    {   
        //Chave Estrangeira
        [MaxLength(25)]
        public string CpnjComprador {get; set;}
        public Comprador Comprador {get; set;} //Variável para navegação
        
        //Chave Estangeira
        public int IdEstoque {get; set;}
        public Estoque Estoque {get; set;} //Variável para navegação
    }

}