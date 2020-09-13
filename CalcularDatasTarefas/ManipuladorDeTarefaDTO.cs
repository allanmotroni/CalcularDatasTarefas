using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDatasTarefas
{
    public class ManipuladorDeTarefaDTO
    {
        public DateTime Inicio { get; internal set; }
        public DateTime Fim { get; internal set; }
        public DateTime ProximoDia { get; set; }

        public override string ToString()
        {
            return $"Início: {Inicio.ToShortDateString()} - Fim: {Fim.ToShortDateString()}";
        }
    }
}
