using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Tarefa
    {
        public int? IdTarefa { get; set; }
        public string Titulo { get; set; }
        public DateTime? DataInicial { get; set; } = DateTime.Now;
        public DateTime DataDeVencimento { get; set; }
        public bool? Concluida { get; set;} = false;

        public Tarefa(int idTarefa, string titulo, DateTime dataDeVencimento)
        {
            IdTarefa = idTarefa;
            Titulo = titulo;
            DataDeVencimento = dataDeVencimento;
        }



    }
}