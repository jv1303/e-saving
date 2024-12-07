using System.ComponentModel.DataAnnotations;
using AspNetCoreGeneratedDocument;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace e_saving.Models
{

public class ContaBanco
    {
        [MaxLength(10)]
        public string Agencia {get; set;}

        [MaxLength(15)]
        public string Bandeira {get; set;} 

        [MaxLength(75)]
        public string Banco {get; set;}

        [MaxLength(20)]
        public string NumeroConta {get; set;}

        [MaxLength(25)]
        public string CpfParceiro {get; set;}

        [MaxLength(25)]
        public string CnpjComprador {get; set;}

        [MaxLength(25)]
        public string CpfCliente {get; set;}

        //métodos para a chave estrangeira
        public Parceiro Parceiro {get;set;}

        public Comprador Comprador {get;set;}

        public Cliente Cliente {get;set;}        
    }
}
