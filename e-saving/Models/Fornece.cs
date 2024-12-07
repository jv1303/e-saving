using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.SignalR;

namespace e_saving.Models 
{

//Tabela intermediária entre Cliente e Item (relação N:N)
public class Fornece 
    {   
        //Chave Estrangeira
        //[ForeignKey("Cliente")]
        public int IdItem {get; set;}
        public Item Item {get; set;} //Variável para navegação
        
        //Chave Estangeira
        //[ForeignKey("Item")]
        [MaxLength(25)]
        public string CpfCliente {get;set;}
        public Cliente Cliente {get;set;} //Variável para navegação
    }

}