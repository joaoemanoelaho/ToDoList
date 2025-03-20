using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList
{
    public class GerenciadorTarefas
    {
        List<Tarefa> tarefas = new List<Tarefa>();

        public List<Tarefa> AdiconarTarefa(string titulo, DateTime dataDeVencimento)
        {
            int idTarefa = tarefas.Count;

            tarefas.Add(new Tarefa(idTarefa, titulo, dataDeVencimento));
            return tarefas;
        }

        public List<Tarefa> RemoverTarefa(int idTarefa)
        {
            int idRemover = idTarefa - 1;

            tarefas.RemoveAt(idRemover);
            return tarefas;
        }

        public List<Tarefa> ListarTarefa()
        {
            foreach (var tarefa in tarefas)
            {
                System.Console.WriteLine($"Id {tarefa.IdTarefa}, Título {tarefa.Titulo}, DataVencimento {tarefa.DataDeVencimento}");
            }

            return tarefas;
        }

        public List<Tarefa> BuscarTarefa(string nomeTarefa)
        {
            List<Tarefa> tarefasBuscadas = new List<Tarefa>();

            System.Console.WriteLine(tarefasBuscadas.FindAll(x => x.Titulo == nomeTarefa));

            return tarefas;
        }

        public List<Tarefa> MarcarConcluido(int numeroTarefa)
        {
            int index = numeroTarefa = 1;

            tarefas[index].Concluida = true;

            foreach (var tarefa in tarefas)
            {

                System.TimeSpan dias = DateTime.Now - tarefa.DataDeVencimento;
                string convertido = dias.ToString("dd");
                int diasEmInteiro = Convert.ToInt32(convertido);

                if (tarefa.Concluida == true)
                {
                    System.Console.WriteLine($"[X] {tarefa.Titulo} (Concluido)");

                }
                else if (diasEmInteiro <= 2)
                {
                    System.Console.WriteLine($"[ ] {tarefa.Titulo} (Vence em {tarefa.DataDeVencimento}, Urgente)");
                }
                else
                {
                    System.Console.WriteLine($"[ ] {tarefa.Titulo} (Vence em {tarefa.DataDeVencimento})");
                }
            }


            return tarefas;
        }


    }
}