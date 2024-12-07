using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.SignalR;

namespace e_saving.Models 
{

//Tabela intermediária entre Cliente e Item (relação N:N)
public class Item
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdItem {get; set;}

        public double Valor {get; set;}

        [MaxLength(50)]
        public string ModeloItem {get; set;}

        [MaxLength(50)]
        public string Tipo {get; set;}

        public int IdPontoColeta {get; set;}

        public int IdEstoque {get; set;}

        //Propriedade de navegação para Fornece (Lista)
        //Coleção de Fornece associados a este item
        public ICollection<Fornece> Fornecimentos { get; set; }

        //Propriedade de naegação para PontoColeta
        public PontoColeta PontoColeta {get;set;}

        //Propriedade de naegação para Estoque
        public Estoque Estoque { get; set; }
    }
}