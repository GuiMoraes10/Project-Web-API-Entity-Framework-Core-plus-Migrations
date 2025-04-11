using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;

// Indica que pertencera a tabela do banco de dados Categorias.
// E uma redundancia pois o migrations ja iniciaria automaticamente por ter sido mapeada no AppDbContext.
[Table("Categorias")]
public class Categoria
{

    // Inicializando a colecao por boa pratica
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }

    [Key] // Indica que CategoriaId sera uma chave primaria, tambem e redundancia pois e reconhecido automaticamente por conta da nomenclatura 'NomeId'
    public int CategoriaId { get; set; }

    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    // Indica que a categoria tera produtos nela, definindo a relacao de um para muitos.
    // Ja seria o suficiente para estabelecer a relacao, sem necessariamente precisar alterar a classe Produto.
    public ICollection<Produto>? Produtos { get; set; }
}
