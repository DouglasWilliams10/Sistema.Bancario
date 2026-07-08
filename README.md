<img width="685" height="629" alt="image" src="https://github.com/user-attachments/assets/3a417f35-9136-4c01-9c8f-7756a204db74" /># 🏦 CDR Bank

<p align="center">

<img src="assets/logo.png" width="180">

# Sistema Bancário

**Projeto Integrador — Jovem Programador SENAC Brusque**

Simulação de um sistema bancário desenvolvido em **C#**, **.NET**, **Windows Forms** e **SQL Server**, aplicando conceitos de Engenharia de Software, Banco de Dados, Programação Orientada a Objetos e Arquitetura em Camadas.

![GitHub repo size](https://img.shields.io/github/repo-size/SEU-USUARIO/CDR-Bank)
![GitHub last commit](https://img.shields.io/github/last-commit/SEU-USUARIO/CDR-Bank)
![GitHub License](https://img.shields.io/github/license/SEU-USUARIO/CDR-Bank)
![C#](https://img.shields.io/badge/C%23-.NET%208-68217A)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D7)

</p>

---

# 📑 Índice

* Sobre
* Demonstração
* Funcionalidades
* Arquitetura
* Tecnologias
* Estrutura do Projeto
* Regras de Negócio
* Banco de Dados
* Instalação
* Como Executar
* Testes
* Roadmap
* Contribuição
* Equipe
* Licença

---

# 📖 Sobre

O **CDR Bank** é um sistema bancário desktop desenvolvido como Projeto Integrador do curso **Jovem Programador - SENAC**.

O projeto simula as principais funcionalidades de um caixa eletrônico, oferecendo uma experiência semelhante à de um sistema bancário real.

Durante seu desenvolvimento foram aplicados conceitos de:

* Programação Orientada a Objetos
* Arquitetura em Camadas
* Banco de Dados Relacional
* CRUD
* Validação de Dados
* Regras de Negócio
* Segurança de Acesso
* Testes do Sistema

---

# 📸 Telas do Sistema

## Login

<img src="assets/<img width="667" height="436" alt="image" src="https://github.com/user-attachments/assets/3f7af6b4-b27f-4980-85e9-bd43af54c116" />
">

---

## Cadastro

<img src="<img width="688" height="628" alt="image" src="https://github.com/user-attachments/assets/35819057-f739-4652-9962-5f92715d23c3" />

">

---

## Tela Principal - Saldo

<img src="<img width="701" height="375" alt="image" src="https://github.com/user-attachments/assets/29c95396-22f0-47ec-8c15-3f2ab2a88376" />
">

---

## Depósito, Saque e Transferência

<img src="<img width="717" height="397" alt="image" src="https://github.com/user-attachments/assets/02fe5cea-d10f-4e86-9d21-23022b8f0a7a" />
">

---

## Extrato e Rendimentos

<img src="<img width="704" height="401" alt="image" src="https://github.com/user-attachments/assets/7fac29c7-a4c3-4f8c-9200-feb77d728703" />
">

---

# 🚀 Funcionalidades

✔ Cadastro de clientes

✔ Login utilizando CPF e senha

✔ Consulta de saldo

✔ Depósito

✔ Saque

✔ Transferência entre contas

✔ Extrato bancário

✔ Validação de CPF

✔ Registro de movimentações

✔ Persistência em banco de dados

---

# 🏗 Arquitetura

```text
CDR Bank
│
├── Controllers
│
├── Models
│
├── DAO
│
├── Services
│
├── Database
│
├── Utils
│
├── Views (Windows Forms)
│
└── Program.cs
```

---

# 💻 Tecnologias

| Tecnologia       | Utilização          |
| ---------------- | ------------------- |
| C#               | Linguagem principal |
| .NET             | Framework           |
| Windows Forms    | Interface gráfica   |
| SQL Server       | Banco de Dados      |
| Entity Framework | ORM                 |
| Git              | Versionamento       |
| GitHub           | Repositório         |

---

# 🗄 Banco de Dados

O sistema utiliza banco de dados relacional contendo tabelas como:

* Usuários
* Contas
* Movimentações
* Extratos

Toda movimentação é registrada automaticamente para consulta posterior.

---

# 📋 Regras de Negócio

O sistema impede:

❌ Login inválido

❌ Senha incorreta

❌ Depósito de valor zero

❌ Depósito negativo

❌ Saque maior que o saldo

❌ Saque negativo

❌ Transferência para CPF inexistente

✔ Atualização automática do saldo

✔ Registro no extrato

---

# ⚙ Instalação

Clone o projeto

```bash
git clone [https://github.com/SEU-USUARIO/CDR-Bank.git](https://github.com/DouglasWilliams10/Sistema.Bancario.git)
```

Entre na pasta

```bash
cd Sistema.Bancario
```

Abra a solução no Visual Studio.

Configure a conexão com o SQL Server.

Execute as migrations (caso utilize Entity Framework).

Inicie o projeto.

---

# ▶ Como Executar

1. Cadastrar um usuário

2. Fazer Login

3. Depositar um valor

4. Consultar saldo

5. Realizar saque

6. Efetuar transferência

7. Consultar extrato

---

# 🧪 Testes

Durante o desenvolvimento foram realizados testes para:

* Login inválido
* Cadastro
* Validação de CPF
* Depósito inválido
* Saque acima do saldo
* Transferência
* Persistência de dados
* Atualização de saldo
* Extrato

---

# 🛣 Roadmap

* [x] Cadastro
* [x] Login
* [x] Depósito
* [x] Saque
* [x] Transferência
* [x] Extrato
* [ ] Recuperação de senha
* [ ] Dashboard administrativo
* [ ] API REST
* [ ] Aplicativo Mobile
* [ ] Geração de PDF
* [ ] Autenticação em dois fatores
* [ ] Integração bancária

---

# 🤝 Contribuições

Contribuições são bem-vindas.

Caso encontre algum problema ou tenha sugestões, abra uma Issue ou envie um Pull Request.

---

# 👨‍💻 Equipe

**Carlos Linhares**

**Douglas Williams da Silva Porto**

**Rayane Biancato**

Projeto desenvolvido durante o curso **Jovem Programador - SENAC Brusque**.

---

# ⭐ Se este projeto foi útil...

Deixe uma ⭐ no repositório.

Ela ajuda muito no crescimento do projeto.

---

# 📄 Licença

Este projeto possui finalidade exclusivamente acadêmica e educacional.
