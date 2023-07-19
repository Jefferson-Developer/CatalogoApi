using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCatalogo.Models;


public class Categoria
{
    
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }

    [Key]
    public int CategoriaId { get; set; }

    [Required]
    [MaxLength(255)]
    public string? Nome { get; set; }

    [Required]
    [MaxLength(255)]
    public string? ImagemUrl { get; set; }
    public ICollection<Produto>? Produtos { get; set; }
}
