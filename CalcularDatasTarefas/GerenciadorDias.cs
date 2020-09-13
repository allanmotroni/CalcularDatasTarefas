using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDatasTarefas
{
    
    public class GerenciadorDias
    {
        private IList<DateTime> dias;

        public GerenciadorDias()
        {
            dias = new List<DateTime>();
        }

        public IEnumerable<DateTime> getDias()
        {
            return dias;
        }
                
        public void Adicionar(DateTime data)
        {
            try
            {
                if (DataExiste(data))
                    throw new Exception(string.Format("Data {0} já existe!", data.ToString("dd/MM/yyyy")));

                dias.Add(data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Remover(DateTime data)
        {
            try
            {
                if (!DataExiste(data))
                    throw new Exception(string.Format("Data {0} não existe!", data.ToString("dd/MM/yyyy")));

                return dias.Remove(data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool DataExiste(DateTime data)
        {
            try
            {
                return dias.Any(p => p == data);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
