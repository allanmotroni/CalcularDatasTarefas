namespace CalcularDatasTarefas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTarefa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownTempoDias = new System.Windows.Forms.NumericUpDown();
            this.checkBoxRetirarFinaisDeSemana = new System.Windows.Forms.CheckBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDiasARetirar = new System.Windows.Forms.DataGridView();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRemover = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonAdicionarDiaARetirar = new System.Windows.Forms.Button();
            this.dateTimePickerDiaAretirar = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxTarefas = new System.Windows.Forms.RichTextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempoDias)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiasARetirar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarefa:";
            // 
            // textBoxTarefa
            // 
            this.textBoxTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTarefa.Location = new System.Drawing.Point(58, 12);
            this.textBoxTarefa.Multiline = true;
            this.textBoxTarefa.Name = "textBoxTarefa";
            this.textBoxTarefa.Size = new System.Drawing.Size(373, 47);
            this.textBoxTarefa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Início:";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(58, 68);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(102, 20);
            this.dateTimePickerInicio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tempo (dias):";
            // 
            // numericUpDownTempoDias
            // 
            this.numericUpDownTempoDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTempoDias.Location = new System.Drawing.Point(271, 68);
            this.numericUpDownTempoDias.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTempoDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTempoDias.Name = "numericUpDownTempoDias";
            this.numericUpDownTempoDias.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownTempoDias.TabIndex = 5;
            this.numericUpDownTempoDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxRetirarFinaisDeSemana
            // 
            this.checkBoxRetirarFinaisDeSemana.AutoSize = true;
            this.checkBoxRetirarFinaisDeSemana.Checked = true;
            this.checkBoxRetirarFinaisDeSemana.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRetirarFinaisDeSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRetirarFinaisDeSemana.Location = new System.Drawing.Point(178, 32);
            this.checkBoxRetirarFinaisDeSemana.Name = "checkBoxRetirarFinaisDeSemana";
            this.checkBoxRetirarFinaisDeSemana.Size = new System.Drawing.Size(124, 17);
            this.checkBoxRetirarFinaisDeSemana.TabIndex = 6;
            this.checkBoxRetirarFinaisDeSemana.Text = "Finais de semana";
            this.checkBoxRetirarFinaisDeSemana.UseVisualStyleBackColor = true;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Image = global::CalcularDatasTarefas.Properties.Resources.calculate_16x16;
            this.buttonCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalcular.Location = new System.Drawing.Point(348, 65);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(83, 23);
            this.buttonCalcular.TabIndex = 7;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.ButtonCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDiasARetirar);
            this.groupBox1.Controls.Add(this.buttonAdicionarDiaARetirar);
            this.groupBox1.Controls.Add(this.dateTimePickerDiaAretirar);
            this.groupBox1.Controls.Add(this.checkBoxRetirarFinaisDeSemana);
            this.groupBox1.Location = new System.Drawing.Point(13, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 180);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dias a retirar";
            // 
            // dataGridViewDiasARetirar
            // 
            this.dataGridViewDiasARetirar.AllowUserToAddRows = false;
            this.dataGridViewDiasARetirar.AllowUserToDeleteRows = false;
            this.dataGridViewDiasARetirar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiasARetirar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnData,
            this.ColumnRemover});
            this.dataGridViewDiasARetirar.Location = new System.Drawing.Point(13, 64);
            this.dataGridViewDiasARetirar.MultiSelect = false;
            this.dataGridViewDiasARetirar.Name = "dataGridViewDiasARetirar";
            this.dataGridViewDiasARetirar.ReadOnly = true;
            this.dataGridViewDiasARetirar.Size = new System.Drawing.Size(295, 110);
            this.dataGridViewDiasARetirar.TabIndex = 10;
            this.dataGridViewDiasARetirar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDiasARetirar_CellContentClick);
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "Data";
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.ReadOnly = true;
            this.ColumnData.Width = 140;
            // 
            // ColumnRemover
            // 
            this.ColumnRemover.HeaderText = "Remover";
            this.ColumnRemover.Name = "ColumnRemover";
            this.ColumnRemover.ReadOnly = true;
            this.ColumnRemover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnRemover.Width = 70;
            // 
            // buttonAdicionarDiaARetirar
            // 
            this.buttonAdicionarDiaARetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarDiaARetirar.Image = global::CalcularDatasTarefas.Properties.Resources.signAdd;
            this.buttonAdicionarDiaARetirar.Location = new System.Drawing.Point(124, 26);
            this.buttonAdicionarDiaARetirar.Name = "buttonAdicionarDiaARetirar";
            this.buttonAdicionarDiaARetirar.Size = new System.Drawing.Size(26, 26);
            this.buttonAdicionarDiaARetirar.TabIndex = 9;
            this.buttonAdicionarDiaARetirar.UseVisualStyleBackColor = true;
            this.buttonAdicionarDiaARetirar.Click += new System.EventHandler(this.ButtonAdicionarDiaARetirar_Click);
            // 
            // dateTimePickerDiaAretirar
            // 
            this.dateTimePickerDiaAretirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDiaAretirar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDiaAretirar.Location = new System.Drawing.Point(16, 29);
            this.dateTimePickerDiaAretirar.Name = "dateTimePickerDiaAretirar";
            this.dateTimePickerDiaAretirar.Size = new System.Drawing.Size(102, 20);
            this.dateTimePickerDiaAretirar.TabIndex = 8;
            // 
            // richTextBoxTarefas
            // 
            this.richTextBoxTarefas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTarefas.Location = new System.Drawing.Point(12, 280);
            this.richTextBoxTarefas.Name = "richTextBoxTarefas";
            this.richTextBoxTarefas.Size = new System.Drawing.Size(419, 125);
            this.richTextBoxTarefas.TabIndex = 11;
            this.richTextBoxTarefas.Text = "";
            this.richTextBoxTarefas.WordWrap = false;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Image = global::CalcularDatasTarefas.Properties.Resources.eraser;
            this.buttonLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpar.Location = new System.Drawing.Point(362, 411);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(69, 23);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.ButtonLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 445);
            this.Controls.Add(this.richTextBoxTarefas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.numericUpDownTempoDias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTarefa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular datas das tarefas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempoDias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiasARetirar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTarefa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTempoDias;
        private System.Windows.Forms.CheckBox checkBoxRetirarFinaisDeSemana;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxTarefas;
        private System.Windows.Forms.DataGridView dataGridViewDiasARetirar;
        private System.Windows.Forms.Button buttonAdicionarDiaARetirar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDiaAretirar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewImageColumn ColumnRemover;
    }
}

