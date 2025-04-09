// EF Core Migrations:
// E uma forma de versionar ou seja de manter o esquema de banco de dados sincronizado com
// o modelo do EF Core preservando os dados existentes.

// Modelo de Entidades => cria: Modelo do EF Core => migrations: Banco de dados

// Sempre que voce alterar as classes do modelo de dominio, precisara executar o migrations para
// manter o esquema do banco de dados atualizado.

//-----------------

// Comandos para aplicar o Migrations usando o ED Core Tools:

// Cria o script de migracao
dotnet ef migrations add 'nome'

// Remove o script de migracao criado
dotnet ef migrations remove 'nome'

// Gera o banco de dados e as tabelas com base no script
dotnet ef database update

//-----------------

// Comandos para aplicar o Migrations (Package Manager Console):

// Cria o script de migracao
add-migration 'nome'

// Remove o script de migracao criado
remove-migration 'nome'

// Gera o banco de dados e as tabelas com base no script
update-database