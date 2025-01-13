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


1. **Clone o repositório do projeto**

   ```bash
   git clone https://github.com/BrunodeLuca403/ManagementLibary.git
   cd seu-projeto
   
Restaure os pacotes necessários

2. **Execute o comando abaixo para instalar todas as dependências:**

```bash
dotnet restore

3. **Configure o banco de dados**

<p>Abra o arquivo appsettings.json e atualize a string de conexão em "ConnectionStrings:DefaultConnection" com os dados do seu banco.</p>
Exemplo:

```bash
JSON
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=GerenciamentoBiblioteca;Trusted_Connection=True;"
}

4. **Execute as migrações do Entity Framework Core**

Aplique as migrações para criar as tabelas no banco de dados:

```bash
dotnet ef database update
Inicie o projeto

5. **Execute o seguinte comando para rodar o servidor:**

```bash
dotnet run
Acesse o projeto

6. **Após o servidor iniciar, acesse a aplicação no navegador:**

http://localhost:5000
Ou, se estiver habilitado o HTTPS:

https://localhost:5001
