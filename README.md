# BellaART — Sistema de Gestão Comercial

Sistema desktop desenvolvido em C# Windows Forms para gestão interna de vendas, produtos, clientes e finanças.

---

## Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** .NET Framework 4.7.2
- **Interface:** Windows Forms (WinForms)
- **ORM:** Dapper
- **Banco de Dados:** SQL Server (SQLEXPRESS)
- **IDE:** Visual Studio 2022

---

## Módulos do Sistema

- Login com autenticação
- Cadastro de Clientes
- Cadastro de Categorias
- Cadastro de Produtos
- Cadastro de Impostos
- Registro de Vendas com múltiplos produtos
- Cálculo de Lucro por venda (descontando imposto e custo de produção)
- Gerenciamento de Usuários

---

## Pré-requisitos

- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [SQL Server Express](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- .NET Framework 4.7.2

---

## Como Configurar

### 1. Banco de Dados

1. Abra o **SQL Server Management Studio (SSMS)**
2. Conecte-se ao servidor `.\SQLEXPRESS` com **Windows Authentication**
3. Abra o arquivo `BellaART_Negocio/Database/BellaART_Script.sql`
4. Execute o script — ele criará o banco e todas as tabelas
5. Um usuário padrão será criado automaticamente:
   - **Login:** `admin`
   - **Senha:** `123`

### 2. String de Conexão

Se o nome do seu servidor SQL for diferente de `DAWID\SQLEXPRESS`, altere a string de conexão no arquivo:

```
BellaART_Negocio/Conexao.cs
```

Linha:
```csharp
banco = new SqlConnection(
    "Data Source=DAWID\\SQLEXPRESS;Initial Catalog=BellaART;Integrated Security=true;"
);
```

Substitua `DAWID\\SQLEXPRESS` pelo nome do seu servidor.

### 3. Compilar e Executar

1. Abra o arquivo `BellaART.slnx` no Visual Studio 2022
2. Restaure os pacotes NuGet: **Tools → NuGet Package Manager → Restore**
3. Defina o projeto **BellaART** como Startup Project
4. Pressione **F5** para executar

---

## Estrutura do Projeto

```
BellaART/
├── BellaART/                  # Camada de apresentação (Windows Forms)
│   ├── LoginForm.cs
│   ├── PrincipalForm.cs
│   ├── ProdutoListarForm.cs
│   ├── VendaForm.cs
│   └── ...
├── BellaART_Negocio/          # Camada de negócio e acesso a dados
│   ├── Conexao.cs
│   ├── DAO/
│   ├── Mapeamento/
│   └── Database/
│       └── BellaART_Script.sql
└── README.md
```

---

## Repositório

[https://github.com/davi8266/BellaARTT](https://github.com/davi8266/BellaARTT)

---

## Autor

Dawid Rizzo — 2026
