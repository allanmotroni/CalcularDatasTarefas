using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDatasTarefas
{
    public class ManipuladorDeTarefas
    {
        private IList<Tarefa> tarefas;
        
        public ManipuladorDeTarefas()
        {
            tarefas = new List<Tarefa>();
        }

        public IEnumerable<Tarefa> GetTarefas()
        {
            return tarefas;
        }

        public ManipuladorDeTarefaDTO Calcular(Tarefa tarefa, IEnumerable<DateTime> diasARetirar, bool pularFinaisDeSemana)
        {
            try
            {
                Incluir(tarefa);

                decimal totalDias = tarefa.TempoEmDias;
                DateTime dia = tarefa.Inicio;

                ManipuladorDeTarefaDTO manipuladorDeTarefaDTO = new ManipuladorDeTarefaDTO();

                totalDias = CalcularTotalDeDias(dia, totalDias, pularFinaisDeSemana, diasARetirar);

                IList<DateTime> dias = MontarListaDias(dia, totalDias);

                DateTime inicio = dias.OrderBy(p => p).FirstOrDefault();
                DateTime fim = dias.OrderByDescending(p => p).FirstOrDefault();

                manipuladorDeTarefaDTO = new ManipuladorDeTarefaDTO
                {
                    Inicio = inicio,
                    Fim = fim,
                    ProximoDia = fim.AddDays(CalcularTotalDeDias(fim.AddDays(1), 1, pularFinaisDeSemana, diasARetirar))
                };

                return manipuladorDeTarefaDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Incluir(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
        }

        private int CalcularTotalDeDias(DateTime dia, decimal prazoEmDias, bool pularFinaisDeSemana, IEnumerable<DateTime> diasARetirar)
        {
            int contador = 0;
            int totalDias = 0;
            bool finalDeSemana = false;
            bool diaARetirar = false;

            DateTime diaCorrente = dia;

            while (contador < prazoEmDias)
            {
                finalDeSemana = FinalDeSemana(diaCorrente);
                diaARetirar = DiaARetirar(diaCorrente, diasARetirar);

                if (!diaARetirar &&
                    (!pularFinaisDeSemana || (pularFinaisDeSemana && !finalDeSemana)))
                {
                    contador++;
                }

                diaCorrente = diaCorrente.AddDays(1);
                totalDias++;
            }

            return totalDias;
        }

        private bool DiaARetirar(DateTime dia, IEnumerable<DateTime> diasARetirar)
        {
            return diasARetirar.Any(p => p.Date == dia.Date);
        }

        private bool FinalDeSemana(DateTime dia)
        {
            return dia.DayOfWeek == DayOfWeek.Saturday || dia.DayOfWeek == DayOfWeek.Sunday;
        }

        private IList<DateTime> MontarListaDias(DateTime dia, decimal total)
        {
            IList<DateTime> dias = new List<DateTime>();

            for (int i = 0; i < total; i++)
            {
                dias.Add(dia.AddDays(i));
            }

            return dias;
        }
    }
}
