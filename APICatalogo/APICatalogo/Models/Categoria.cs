using System.Collections.ObjectModel;

namespace APICatalogo.Models;

public class Categoria
{

    // Inicializando a colecao por boa pratica
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }

    public int CategoriaId { get; set; }
    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }

    // Indica que a categoria tera produtos nela, definindo a relacao de um para muitos.
    // Ja seria o suficiente para estabelecer a relacao, sem necessariamente precisar alterar a classe Produto.
    public ICollection<Produto>? Produtos { get; set; }
}
