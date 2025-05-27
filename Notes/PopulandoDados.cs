// Formas de popular dados inicialmente nas tabelas

// 1 - Incluir dados manualmente usando a instrução INSERT INTO.
// 2 - Criar usar o metodo OnModelCreating do arquivo do contexto e definir o codigo usando a propriedade HasData do EF Core para preencher as tabelas com dados.
// 3 - Criar um metodo estatico e definir o codigo para incluir dados usando o metodo AddRange() do EF Core.
// 4 - Criar uma migracao vazia usando o Migrations e usar os metodos Up() e Down() definindo nestes metodos as instrucoes INSERT INTO para incluir dados nas tabelas.

// Populando com a opcao 4:

// 1 - Criar uma nova migracao usando Migrations
dotnet ef migrations add PopulaCategorias

// 2 - Definir os comandos SQL no metodo Up() para incluir dados
insert into categorias(Nome, ImagemUrl)Values('Bebidas','bebidas.jpg')

// 3 - Definir os comandos SQL no metodo Down() para reverter a migracao
delete from categorias

// 4 - Aplicar a migracao
dotnet ef database update

-------------------------------------------------------------------------------

// 1 - Criar uma nova migracao usando Migrations
dotnet ef migrations add PopulaProdutos

// 2 - Definir os comandos SQL no metodo Up() para incluir dados
insert into produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)Values('Suco de Laranja','Suco de Laranja 500 ml', 7.45, 'sucolaranja.jpg', 10, now(), 1)

// 3 - Definir os comandos SQL no metodo Down() para reverter a migracao
delete from produtos

// 4 - Aplicar a migracao
dotnet ef database update