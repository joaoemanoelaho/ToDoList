using System.Diagnostics;
using System.Net.WebSockets;

namespace ToDoList
{
  class Program
  {
    static void Main(String[] args)
    {
      GerenciadorTarefas tarefa = new GerenciadorTarefas();
      int escolha;
      do
      {
        System.Console.WriteLine("=== Gestor de Tarefas ===");
        System.Console.WriteLine("1. Adicionar Tarefa");
        System.Console.WriteLine("2. Remover Tarefa");
        System.Console.WriteLine("3. Listar Tarefas");
        System.Console.WriteLine("4. Buscar Tarefa");
        System.Console.WriteLine("5. Marcar como concluída");
        System.Console.WriteLine("6. Filtrar Tarefas Pendentes");
        System.Console.WriteLine("7. Filtrar Tarefas Urgentes");
        System.Console.WriteLine("8. Sair");
        string input = Console.ReadLine();

        while (!int.TryParse(input, out escolha))
        {
          System.Console.Write("Formato inválido, Por favor digite qualquer coisa para voltar ao menu: ");
          input = Console.ReadLine();
          break;
        }

        switch (escolha)
        {
          case 1:
            System.Console.Write("Digite o nome da tarefa:");
            string titulo = Console.ReadLine();

            if (string.IsNullOrEmpty(titulo))
            {
              System.Console.WriteLine("Valor nulo ou vazio!");
              break;
            }

            System.Console.Write("Digite a data de vencimento no formato (12/02/2023): ");
            string dataDeVencimento = Console.ReadLine();

            string data = DateTime.Now.ToString("dd/MM/yyyy");

            if (!DateTime.TryParse(dataDeVencimento, out DateTime dataConvertida))
            {
              System.Console.WriteLine("Data no formato inválido. Exemplo Correto: (12/02/2023)");
              break;
            }
            else if
            (dataConvertida < DateTime.Parse(data))
            {
              System.Console.WriteLine($"Data inválida. Data menor que data atual ({data}).");
              break;
            }

            tarefa.AdicionarTarefa(titulo, dataConvertida);
            System.Console.WriteLine("Adicionando com sucesso!");
            break;
          case 2:
            tarefa.ListarTarefa();
            System.Console.Write("Digite o id da tafera para remover: ");
            string index = Console.ReadLine();

            if (!int.TryParse(index, out int indexConvertido))
            {
              System.Console.WriteLine("Valor inválido. Exemplo Correto: (1)");
              break;
            }

            tarefa.RemoverTarefa(indexConvertido);
            
            break;
          case 3:
            tarefa.ListarTarefa();
            break;
          case 4:
            System.Console.Write("Digite o nome da tarefa que procura: ");
            string nome = Console.ReadLine();

            if (string.IsNullOrEmpty(nome))
            {
              System.Console.WriteLine("Valor nulo ou vazio!");
              break;
            }

            tarefa.BuscarTarefa(nome);
            break;
          case 5:
            tarefa.ListarTarefa();
            System.Console.Write("Digite o id da tarefa para marcar como concluida: ");
            index = Console.ReadLine();

            if (!int.TryParse(index, out int convertidoIndex))
            {
              System.Console.WriteLine("Valor inválido. Exemplo Correto: (1)");
              break;
            }

            tarefa.MarcarConcluido(convertidoIndex);
            break;
          case 6:
            tarefa.FiltrarTarefaPendente();
            break;
          case 7:
            tarefa.FiltrarTarefaUrgente();
            break;
        }
      } while (escolha != 8);
    }
  }
}