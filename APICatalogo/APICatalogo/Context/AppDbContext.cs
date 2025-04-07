using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context;

// DbContext - Representa uma sessao com o banco de dados sendo a ponte entre as entidades de dominio e o banco
// DbSet<T> - Representa uma colecao de entidades no contexto que podem ser consultadas no banco de dados

// DbContext e responsavel realizar a comunicacao entre as entidades e o banco de dados, gerenciando interacoes, consultas, atualizacoes
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Representa uma tabela no banco de dados que deseja mapear
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
}
