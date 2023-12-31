﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCatalogo.Models;

public class Produto
{

    [Key]
    public int ProdutoId { get; set; }

    [Required]
    [StringLength(255)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(255)]
    public string? Descricao { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }

    [Required]
    [StringLength(255)]
    public string? ImagemUrl { get; set; }
    public float Estoque { get; set; }  
    public DateTime? DataCadastro { get;  set; }

    public int CategoriaId { get; set; }

    public Categoria? Categoria { get; set; }
}
