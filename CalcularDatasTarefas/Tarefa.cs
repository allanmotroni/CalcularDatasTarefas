using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDatasTarefas
{
    public class Tarefa
    {
        public string Nome { get; set; }
        public DateTime Inicio { get; set; }
        public decimal TempoEmDias { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} - Início: {Inicio} - Tempo em dia: {TempoEmDias}";
        }

    }
}
