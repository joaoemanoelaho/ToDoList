using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList
{
    public class GerenciadorTarefas
    {
        List<Tarefa> tarefas = new List<Tarefa>();

        public List<Tarefa> AdicionarTarefa(string titulo, DateTime dataDeVencimento)
        {
            int idTarefa = tarefas.Count + 1;

            tarefas.Add(new Tarefa(idTarefa, titulo, dataDeVencimento));
            return tarefas;
        }

        public List<Tarefa> RemoverTarefa(int idTarefa)
        {
            int idRemover = idTarefa - 1;

            if (idRemover >= 0 && idRemover < tarefas.Count)
            {
                tarefas.RemoveAt(idRemover);
                System.Console.WriteLine("Removido com sucesso!");
            }
            else
            {
                System.Console.WriteLine("Índice inválido. Nenhuma tarefa removida.");
            }

            return tarefas;
        }

        public List<Tarefa> BuscarTarefa(string nomeTarefa)
        {
            List<Tarefa> tarefasBuscadas = tarefas.FindAll(x => x.Titulo == nomeTarefa);
            System.Console.WriteLine("=== Tarefas ===");

            foreach (var tarefa in tarefasBuscadas)
            {
                System.TimeSpan data = DateTime.Now - tarefa.DataDeVencimento;
                string dias = data.ToString("dd");
                int diasEmInteiro = Convert.ToInt32(dias);

                if (tarefa.Concluida == true)
                {
                    System.Console.WriteLine($"{tarefa.IdTarefa}. [X] {tarefa.Titulo} (Concluido)");
                }
                else if (diasEmInteiro <= 1)
                {
                    System.Console.WriteLine($"{tarefa.IdTarefa}. [ ] {tarefa.Titulo} (Vence em {tarefa.DataDeVencimento.ToString("dd/MM/yyyy")}, Urgente!)");
                }
                else
                {
                    System.Console.WriteLine($"{tarefa.IdTarefa}. [ ] {tarefa.Titulo} (Vence em {tarefa.DataDeVencimento.ToString("dd/MM/yyyy")})");
                }
            }

            return tarefas;
        }

        public List<Tarefa> ListarTarefa()
        {
            System.Console.WriteLine("=== Tarefas ===");

            int index = 1;

            if (tarefas.Count == 0)
            {
                System.Console.WriteLine("Nenhum tarefa adicionada!");
            }

            foreach (var tarefa in tarefas)
            {
                System.TimeSpan data = DateTime.Now - tarefa.DataDeVencimento;
                string dias = data.ToString("dd");
                int diasEmInteiro = Convert.ToInt32(dias);

                tarefa.IdTarefa = index;

                if (tarefa.Concluida == true)
                {
                    System.Console.WriteLine($"{tarefa.IdTarefa}. [X] {tarefa.Titulo} (Concluido)");
                }
                else if (diasEmInteiro <= 1)
                {
                    System.Console.WriteLine($"{tarefa.IdTarefa}. [ ] {tarefa.Titulo} (Vence em {tarefa.DataDeVencimento.ToString("dd/MM/yyyy")}, Urgente!)");
                }
                else
                {
                    System.Console.WriteLine($"{tarefa.IdTarefa}. [ ] {tarefa.Titulo} (Vence em {tarefa.DataDeVencimento.ToString("dd/MM/yyyy")})");
                }
                index++;
            }


            return tarefas;
        }

        public List<Tarefa> MarcarConcluido(int numeroTarefa)
        {
            int index = numeroTarefa - 1;

            if (index >= 0 && index < tarefas.Count)
            {
                tarefas[index].Concluida = true;
                System.Console.WriteLine("Removido com sucesso!");
            }
            else
            {
                System.Console.WriteLine("Índice inválido. Nenhuma tarefa marcada como concluída.");
            }

            ListarTarefa();

            return tarefas;
        }

        public List<Tarefa> FiltrarTarefaPendente()
        {
            System.Console.WriteLine("=== Tarefas ===");
            foreach (var tarefa in tarefas)
            {
                System.TimeSpan data = DateTime.Now - tarefa.DataDeVencimento;
                string dias = data.ToString("dd");
                int diasEmInteiro = Convert.ToInt32(dias);

                if (tarefa.Concluida != true)
                {
                    if (diasEmInteiro <= 1)
                    {
                        System.Console.WriteLine($"{tarefa.IdTarefa}. [ ] {tarefa.Titulo} (Vence em {tarefa.DataDeVencimento.ToString("dd/MM/yyyy")}, Urgente!)");
                    }
                    else
                    {
                        System.Console.WriteLine($"{tarefa.IdTarefa}. [ ] {tarefa.Titulo} (Vence em {tarefa.DataDeVencimento.ToString("dd/MM/yyyy")})");
                    }
                }

            }


            return tarefas;
        }

        public List<Tarefa> FiltrarTarefaUrgente()
        {
            System.Console.WriteLine("=== Tarefas ===");
            foreach (var tarefa in tarefas)
            {
                System.TimeSpan data = DateTime.Now - tarefa.DataDeVencimento;
                string dias = data.ToString("dd");
                int diasEmInteiro = Convert.ToInt32(dias);

                if (tarefa.Concluida != true)
                {
                    if (diasEmInteiro <= 1)
                    {
                        System.Console.WriteLine($"{tarefa.IdTarefa}. [ ] {tarefa.Titulo} (Vence em {tarefa.DataDeVencimento.ToString("dd/MM/yyyy")}, Urgente!)");
                    }
                }
            }

            return tarefas;
        }


    }
}