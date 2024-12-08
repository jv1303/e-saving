using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.SignalR;

namespace e_saving.Models 
{

//Tabela intermediária entre Cliente e Item (relação N:N)
public class PontoColeta
    {   
        [MaxLength(25)]
        public string CnpjParceiro {get; set;}

        public int? ItensColetados {get; set;}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPontoColeta {get; set;}

        public int? Pontuacao {get; set;}


        //Chave estrangeira
        [MaxLength(25)]
        public string CpfParceiro {get; set;}

        //Propriedade de navegação para Fornece (Lista)
        //Coleção de Fornece associados a este item
        public ICollection<Fornece> Fornecimentos { get; set; }

        //Propriedade de naegação para PontoColeta
        public ICollection<Item> Itens {get;set;}

        //Propriedade de navegação para Parceiro (Lista)
        public Parceiro Parceiro {get;set;}
    }
}