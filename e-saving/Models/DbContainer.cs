using System.Collections.Generic;

namespace e_saving.Models;
public class InformacoesContainer
{
    public List<Cliente> Clientes { get; set; }
    public List<Parceiro> Parceiros { get; set; }
    public List<Comprador> Compradores { get; set; }
}