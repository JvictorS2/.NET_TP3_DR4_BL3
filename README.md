# Trabalho acadêmico, Engenharia da computação (Instituto Infnet - 3 semestre) 
## Teste de Performance 3 - Desenvolvimento Web com .NET e Bases de Dados  

Objetivo deste projeto é demostrar a capacidade de criar um projeto ASP.NET utilizando o EntityFrameWork  

### Ferramentas utilizadas 
- Visual Studio 2022 (C#)
- SqLite (Banco de dados)

### Pacotes utilizados
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Sqlit

### Competências abordadas 
- Criar e utilizar uma classe DbContexto 
- Utilizar classe contexto para configuração de banco de dados, controllers e string de conexão
- Criação de Controller, View e CRUD utilizando EntityFramework 
- Utilizar arquivos estáticos para gerar uma view mais agradável 
- Utilizar Banco de dados para persistir dados

  ### Contexto do projeto
  Uma classe DbContext interage com uma classe Computadores: Id, Marca, Processador, Placa Mãe, Memória, HD, NumeroPratrimonio, Data de compra, com id como chave primária,
  criar um model de tabela por meio de migrations e os dados são armazenados em um arquivo de banco de dados (bd ou sqlite), por meio do DbContext e Computadores cria-se a
  Controller Computadores por meio do EntityFrameWork com uma View e CRUD, as Views tem um visual modificado por arquivos CSS.
