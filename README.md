# 🏫 Sistema Escolar Console - C# .NET

Descrição breve:
Projeto de console em C# (.NET 6/7/8) para gerenciar cadastro de alunos, incluindo funcionalidades de adicionar, listar, buscar por matrícula e remover.



## 📋 Índice

- [Sobre o Projeto](#sobre-o-projeto)  
- [Funcionalidades](#funcionalidades)  
- [Pré-requisitos](#pré-requisitos)  
- [Como Executar](#como-executar)  
- [Exemplos de Uso](#exemplos-de-uso)  
- [Estrutura do Código](#estrutura-do-código)  
- [Contribuindo](#contribuindo)  
- [Autor](#autor)



## Sobre o Projeto

Este sistema visa demonstrar conceitos de Programação Orientada a Objetos (POO) em C#: definição de classes, atributos, construtores, listas, buscas, remoções e interação com o usuário via console. Ideal como base de estudo e prática.



## Funcionalidades

- Adicionar novo aluno (nome, idade, curso, matrícula)  
- Listar todos os alunos cadastrados  
- Buscar aluno pela matrícula  
- Remover aluno pelo número de matrícula  
- Interface simples baseada em menu no console



## Pré-requisitos

- [.NET SDK 6+ ou 7/8](https://dotnet.microsoft.com)  
- Sistema operacional compatível (Windows, Linux, macOS)  
- Editor de código (Visual Studio, VS Code, Rider, etc.)



## Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/swetonyancelmo/sistema-escolar.git
   cd sistema-escolar
2. Compile o projeto:
    ```bash
   dotnet build
3. Execute a aplicação:
    ```bash
    dotnet run --project cadastroAlunos

## Exemplos de Uso
Após iniciar, o sistema exibe um menu:
```diff
=== Bem vindo ao Sistema da Escola ===
1 - Adicionar novo aluno
2 - Listar alunos
3 - Buscar aluno por matrícula
4 - Remover aluno
0 - Encerrar
```
- Adicionar: preencha nome, idade, curso e matrícula.

- Listar: exibe todos os alunos cadastrados.

- Buscar: digite uma matrícula e, se existir, o aluno será exibido.

- Remover: insira a matrícula do aluno que deseja excluir.

## Estrutura do Código
```text
cadastroAlunos/
│
├─ Models/
│   └─ Aluno.cs  // define a classe Aluno com atributos e construtor
├─ Program.cs    // loop principal e menu de operações
└─ cadastroAlunos.csproj
```
- Aluno.cs: contém os atributos (Nome, Idade, Curso, Matricula) e o construtor.

- Program.cs: lógica de menu, leitura do console e manipulação da lista de alunos.

## Contribuindo

Contribuições, sugestões de melhorias e correções são sempre bem-vindas!

1. Fork o projeto

2. Crie uma branch (git checkout -b minha-feature)

3. Commit suas alterações (git commit -m 'feat: nova funcionalidade X')

4. Push para sua branch (git push origin minha-feature)

5. Abra um Pull Request

## Autor

Desenvolvido por [Swetony Ancelmo](https://www.linkedin.com/in/swetony-ancelmo/)

- 📧 Email: swetonyancelmo@gmail.com
- 💼 LinkedIn: [linkedin.com/in/swetonyancelmo](https://www.linkedin.com/in/swetony-ancelmo/)

Sinta-se à vontade para entrar em contato, tirar dúvidas ou dar sugestões!