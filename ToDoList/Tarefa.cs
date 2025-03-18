using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Tarefa
    {
        public string Titulo { get; set; }
        public DateTime DataDeVencimento { get; set; }

        public Tarefa(string titulo, DateTime dataDeVencimento){
            Titulo = titulo;
            DataDeVencimento = dataDeVencimento;
        }

    }
}