using cadastroAlunos.Models;

List<Aluno> listaAlunos = new List<Aluno>();
bool executando = true;

while (executando)
{
  Console.Clear();
  Console.WriteLine("=== Bem vindo ao Sistema da Escola ===");
  Console.WriteLine("1 - Adicionar novo aluno");
  Console.WriteLine("2 - Listar alunos");
  Console.WriteLine("3 - Buscar aluno por matrícula");
  Console.WriteLine("4 - Remover aluno");
  Console.WriteLine("0 - Encerrar");
  string op = Console.ReadLine();

  switch (op)
  {
    case "1":
      Console.Clear();
      Console.WriteLine("=== Cadastro de Aluno ===");
      Console.WriteLine("Digite o nome do aluno: ");
      string nome = Console.ReadLine();

      Console.WriteLine("Digite a idade do aluno: ");
      int idade = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o curso do aluno: ");
      string curso = Console.ReadLine();

      Console.WriteLine("Digite a matrícula do aluno: ");
      int matricula = int.Parse(Console.ReadLine());

      Aluno novoAluno = new Aluno(nome, idade, curso, matricula);
      listaAlunos.Add(novoAluno);

      Console.WriteLine("Aluno adicionado com sucesso!");
      Console.WriteLine("Pressione qualquer tecla para continuar...");
      Console.ReadKey();
      break;

    case "2":
      Console.Clear();
      Console.WriteLine("=== Alunos ===");
      foreach (var aluno in listaAlunos)
      {
        Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Curso: {aluno.Curso}, Matrícula: {aluno.Matricula}");
      }

      Console.WriteLine("Pressione qualquer tecla para continuar...");
      Console.ReadKey();
      break;

    case "3":
      Console.Clear();
      Console.WriteLine("Digite a matrícula do aluno: ");
      int matriculaDigitada = int.Parse(Console.ReadLine());
      bool encontrado = false;
      foreach (var aluno in listaAlunos)
      {
        if (aluno.Matricula == matriculaDigitada)
        {
          Console.WriteLine("Aluno Encontrado: ");
          Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Curso: {aluno.Curso}, Matrícula: {aluno.Matricula}");
          encontrado = true;
          break;
        }
      }
      if (!encontrado)
      {
        Console.WriteLine("Aluno não encontrado.");
      }
      Console.WriteLine("Pressione qualquer tecla para continuar...");
      Console.ReadKey();
      break;

    case "4":
      Console.Clear();
      Console.WriteLine("Digite a matrícula do aluno:");
      int matriculaDigitadaParaRemover = int.Parse(Console.ReadLine());
      bool removido = false;

      for (int i = 0; i < listaAlunos.Count; i++)
      {
        if (listaAlunos[i].Matricula == matriculaDigitadaParaRemover)
        {
          listaAlunos.RemoveAt(i);
          removido = true;
          Console.WriteLine("Aluno removido com sucesso!");
          break;
        }
      }
      if (!removido)
      {
        Console.WriteLine("Aluno não encontrado.");
      }
      Console.WriteLine("Pressione qualquer tecla para continuar...");
      Console.ReadKey();
      break;

    case "0":
      executando = false;
      break;

    default:
      Console.WriteLine("Opção inválida, digite novamente.");
      Console.WriteLine("Pressione qualquer tecla para continuar...");
      Console.ReadKey();
      break;
  }
}
