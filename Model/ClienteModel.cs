using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPag.Model;

[Table("Cliente")]
public class ClienteModel
{
    [Column("Id")]
    [Display(Name = "Id")]
    public int Id {get;set;}

    [Column("Cliente")]
    [Display(Name = "NomeCliente")]
    public string NomeCliente {get;set;}

    public int CodigoBanco {get;set;}
}
