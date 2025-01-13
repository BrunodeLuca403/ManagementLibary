#GERENCIAMENTO DE BIBLIOTECA

<p>Este projeto consiste no desenvolvimento de um sistema para gerenciamento de biblioteca. Dependendo da permissão do usuário no sistema, será possível realizar operações de CRUD (Criar, Ler, Atualizar, Deletar) para livros, empréstimos e usuários. Apesar de parecer simples, o sistema integra diversas tecnologias avançadas. Atualmente, o desenvolvimento está focado no Back-end, mas o Front-end será implementado futuramente utilizando Blazor.</p>

##Funcionalidades

Gerenciamento de livros (CRUD)
Gerenciamento de empréstimos (CRUD)
Gerenciamento de usuários (CRUD)
Controle de permissões de acesso
Validação de dados

<ul>
  <li>Gerenciamento de livros (CRUD)</li>
  <li>Gerenciamento de empréstimos (CRUD)</li>
  <li>Gerenciamento de usuários (CRUD)</li>
  <li>Controle de permissões de acesso </li>
  <li>Validação de dados</li>
  <li>Regras gerais do sistema</li>
</ul>

##Tecnologias Utilizadas

<ul> 
  <li>.NET 8</li> 
  <li>Entity Framework Core</li> 
  <li>CQRS</li> 
  <li>Fluent Validation</li> 
  <li>DTOs</li> 
  <li>Arquitetura Limpa</li> 
  <li>Repositórios</li> </ul>
  
##Estrutura do Projeto

###O projeto segue uma abordagem de Arquitetura Limpa, com separação clara de responsabilidades:

<ul>
  <li>Camada de Aplicação: Contém os casos de uso, validações e DTOs.</li>
  <li>Camada de Domínio: Inclui as entidades e regras de negócio.</li>
  <li>Camada de Infraestrutura: Abrange o acesso a dados (repositorios) e integrações externas.</li>
  <li>Camada de Apresentação: (Em desenvolvimento) Implementação do Front-end utilizando Blazor.</li>
</ul>


## Mapeamento de tabelas



## Como Executar o Projeto?

Siga os passos abaixo para configurar e executar o projeto localmente:

### Pré-requisitos

Certifique-se de que os seguintes softwares estão instalados no seu ambiente:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)  
- [SQL Server](https://www.microsoft.com/en-us/sql-server).
- Ferramenta de sua preferência para gerenciar o banco de dados (ex.: SQL Server Management Studio, Azure Data Studio).  

### Passos para Executar

    <h2>1. Clone o repositório do projeto</h2>
    <p>Clone o repositório e entre no diretório:</p>
    <pre><code>git clone https://github.com/BrunodeLuca403/ManagementLibary.git
cd seu-projeto
    </code></pre>

    <h2>2. Restaure os pacotes necessários</h2>
    <p>Execute o comando abaixo para instalar todas as dependências:</p>
    <pre><code>dotnet restore</code></pre>
    <p>Configure o banco de dados abrindo o arquivo <code>appsettings.json</code> e atualizando a string de conexão em 
    <code>ConnectionStrings:DefaultConnection</code> com os dados do seu banco. Exemplo:</p>
    <pre><code>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=GerenciamentoBiblioteca;Trusted_Connection=True;"
  }
}
    </code></pre>

    <h2>3. Execute as migrações do Entity Framework Core</h2>
    <p>Aplique as migrações para criar as tabelas no banco de dados:</p>
    <pre><code>dotnet ef database update</code></pre>

    <h2>4. Inicie o projeto</h2>
    <p>Execute o seguinte comando para rodar o servidor:</p>
    <pre><code>dotnet run</code></pre>

    <h2>5. Acesse o projeto</h2>
    <p>Após o servidor iniciar, acesse a aplicação no navegador:</p>
    <pre><code>http://localhost:5000</code></pre>
    <p>Ou, se estiver habilitado o HTTPS:</p>
    <pre><code>https://localhost:5001</code></pre>
