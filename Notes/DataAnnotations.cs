// Data Annotations

// Sao um conjunto de atributos que podem ser aplicados a classes e seus membros 
// para fornecer metadados sobre como esses recursos devem ser tratados pelo sistema.

// - Realizar validacoes de entrada de dados
// - Influenciar o comportamento do modelo de dados
System.ComponentModel.DataAnnotations
System.ComponentModel.DataAnnotations.Schema


// O EF Core usa um conjunto de regras (convencao padrao) para criar e atualizar as
// tabelas e o esquema do banco de dados quando as migracoes sao aplicadas.

// Exemplo:
// Para o MySQL o tipo string e mapeado para o tipo longtext e o tipo decimal usa uma
// precisao de 65 digitos com 30 casas decimais.
// Os atibutos Data Annotations podem sobrescrever as convencoes usadas pelo EF Core.


// Data Annotations para sobrescrever as convencoes do EF Core:

Key           // - Identifica a propriedade como uma chave primaria na tabela.
Table("nome") // - Define o nome da tabela para a qual a classe sera mapeada.
Column        // - Define a coluna na tabela para a qual a propriedade sera mapeada.
DataType      // - Associa um tipo de dados adicional a uma propriedade.
ForeignKey    // - Especifica que a propriedade e usada como uma chave estrangeira.
NotMapped     // - Exclui a propriedade do mapeamento.
StringLength  // - Define o tamanho minimo e maximo permitido para o tipo.
Required      // - Especifica que o valor do campo e obrigatorio(NOT NULL).


// Data Annotations - Aplicacao nas classes Categoria e Produto:

// 1 - Propriedades do tipo string:
[StringLength(XX), ErrorMessage = "texto da mensagem de erro"]

// 2 - Propriedades do tipo decimal:
[Column(TypeName = "decimal(10,2)")]

// 3 - Valores obrigatorios:
[Required(ErrorMessage = "texto da mensagem de erro")]