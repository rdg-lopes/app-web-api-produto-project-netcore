using System.ComponentModel.DataAnnotations.Schema;

namespace produto_microservice.Databases;
[Table("PRODUTO_MODEL")]
public class ProdutoEntity 
{
    [Column("ID")]
    public int id {get;set;}
    [Column("NOME")]
    public string nome {get;set;}

}