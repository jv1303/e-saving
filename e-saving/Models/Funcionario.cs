using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.SignalR;

namespace e_saving.Models 
{

public class Funcionario
    {   
        [MaxLength(30)]
        public string SenhaFuncionario {get; set;}
        
        [MaxLength(255)]
        public string NomeUsuario {get; set;}
        
        [MaxLength(150)]
        public string EmailConstitucional {get; set;}

        [Key]
        [MaxLength(25)]
        public string CpfFuncionario {get;set;}

        [MaxLength(255)]
        public string NomeFuncionario {get; set;}

        public byte []? FotoPerfilFuncionario {get; set;}

        public int? IdEstoque {get; set;}
        
        //Propriedade de navegação para estoque (Lista)
        public Estoque Estoque {get; set;}
    }
}
