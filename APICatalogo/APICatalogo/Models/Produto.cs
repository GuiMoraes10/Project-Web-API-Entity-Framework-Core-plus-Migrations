namespace APICatalogo.Models;

public class Produto
{
    public int ProdutoId {  get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco {  get; set; }
    public string? ImagemUrl {  get; set; }
    public float Estoque {  get; set; }
    public DateTime DataCadastro { get; set; }

    // Explicita o Id que sera criado como Foreign Key no banco de dados.
    public int CategoriaId {  get; set; }

    // Explicita que o Produto ira pertencer a uma Categoria.
    public Categoria? Categoria { get; set; }
}
