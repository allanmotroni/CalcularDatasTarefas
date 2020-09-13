using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularDatasTarefas
{
    public partial class Form1 : Form
    {
        private GerenciadorDias gerenciadorDiasARetirar;
        private ManipuladorDeTarefas manipuladorDeTarefas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gerenciadorDiasARetirar = new GerenciadorDias();
            manipuladorDeTarefas = new ManipuladorDeTarefas();
        }

        private void ButtonAdicionarDiaARetirar_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarDiaARetirar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionarDiaARetirar()
        {
            try
            {
                DateTime dia = dateTimePickerDiaAretirar.Value;
                gerenciadorDiasARetirar.Adicionar(dia);
                IncluirListaDiaARetirar(dia);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void IncluirListaDiaARetirar(DateTime dia)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell celulaData = new DataGridViewTextBoxCell();
                celulaData.Value = dia;
                row.Cells.Add(celulaData);

                DataGridViewImageCell celulaImagemRemover = new DataGridViewImageCell();
                celulaImagemRemover.Value = (System.Drawing.Image)Properties.Resources.delete2;
                row.Cells.Add(celulaImagemRemover);

                dataGridViewDiasARetirar.Rows.Add(row);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ExcluirDiasARetirar(DateTime dia, int indice)
        {
            try
            {
                gerenciadorDiasARetirar.Remover(dia);
                ExcluirListaDiaARetirar(indice);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ExcluirListaDiaARetirar(int indice)
        {
            try
            {
                dataGridViewDiasARetirar.Rows.RemoveAt(indice);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DataGridViewDiasARetirar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indiceLinha = e.RowIndex;
                if (indiceLinha > -1)
                {
                    int indiceColuna = e.ColumnIndex;
                    switch (dataGridViewDiasARetirar.Columns[indiceColuna].Name)
                    {
                        case "ColumnRemover":
                            {
                                DateTime dia = Convert.ToDateTime(dataGridViewDiasARetirar.Rows[indiceLinha].Cells["ColumnData"].Value);
                                ExcluirDiasARetirar(dia, indiceLinha);
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Tarefa tarefa = CriarTarefa();

                ManipuladorDeTarefaDTO manipuladorDeTarefaDTO = manipuladorDeTarefas.Calcular(tarefa, gerenciadorDiasARetirar.getDias(), checkBoxRetirarFinaisDeSemana.Checked);

                dateTimePickerInicio.Value = manipuladorDeTarefaDTO.ProximoDia;

                richTextBoxTarefas.AppendText(string.Format("{1}{0}{2}{0}", Environment.NewLine,tarefa.Nome, manipuladorDeTarefaDTO.ToString()));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Tarefa CriarTarefa()
        {
            return new Tarefa()
            {
                Nome = textBoxTarefa.Text,
                Inicio = dateTimePickerInicio.Value,
                TempoEmDias = numericUpDownTempoDias.Value
            };
        }

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxTarefa.Clear();

                dateTimePickerInicio.Value = DateTime.Now;
                numericUpDownTempoDias.Value = 1;

                dateTimePickerDiaAretirar.Value = DateTime.Now;

                checkBoxRetirarFinaisDeSemana.Checked = true;

                LimparGridDiasARetirar();                

                richTextBoxTarefas.Clear();

                gerenciadorDiasARetirar = new GerenciadorDias();
                manipuladorDeTarefas = new ManipuladorDeTarefas();

                textBoxTarefa.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparGridDiasARetirar()
        {
            dataGridViewDiasARetirar.Rows.Clear();
        }
    }
}
