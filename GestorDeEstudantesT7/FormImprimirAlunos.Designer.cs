namespace GestorDeEstudantesT7
{
    partial class FormImprimirAlunos
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
            this.dataGridViewListaDeAlunos = new System.Windows.Forms.DataGridView();
            this.buttonArquivoTexto = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataInicial = new System.Windows.Forms.DateTimePicker();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeAlunos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListaDeAlunos
            // 
            this.dataGridViewListaDeAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaDeAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListaDeAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaDeAlunos.Location = new System.Drawing.Point(12, 74);
            this.dataGridViewListaDeAlunos.Name = "dataGridViewListaDeAlunos";
            this.dataGridViewListaDeAlunos.Size = new System.Drawing.Size(776, 297);
            this.dataGridViewListaDeAlunos.TabIndex = 1;
            // 
            // buttonArquivoTexto
            // 
            this.buttonArquivoTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonArquivoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArquivoTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonArquivoTexto.Location = new System.Drawing.Point(207, 377);
            this.buttonArquivoTexto.Name = "buttonArquivoTexto";
            this.buttonArquivoTexto.Size = new System.Drawing.Size(371, 61);
            this.buttonArquivoTexto.TabIndex = 17;
            this.buttonArquivoTexto.Text = "Salvar Em Arquivo de Texto";
            this.buttonArquivoTexto.UseVisualStyleBackColor = false;
            this.buttonArquivoTexto.Click += new System.EventHandler(this.buttonArquivoTexto_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(157, 30);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 19;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerDataFinal);
            this.groupBox1.Controls.Add(this.dateTimePickerDataInicial);
            this.groupBox1.Controls.Add(this.radioButtonSim);
            this.groupBox1.Controls.Add(this.radioButtonNao);
            this.groupBox1.Location = new System.Drawing.Point(395, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 62);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Usar intervalo de dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nascidos entre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "e";
            // 
            // dateTimePickerDataFinal
            // 
            this.dateTimePickerDataFinal.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerDataFinal.Location = new System.Drawing.Point(209, 34);
            this.dateTimePickerDataFinal.Name = "dateTimePickerDataFinal";
            this.dateTimePickerDataFinal.Size = new System.Drawing.Size(38, 20);
            this.dateTimePickerDataFinal.TabIndex = 25;
            // 
            // dateTimePickerDataInicial
            // 
            this.dateTimePickerDataInicial.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerDataInicial.Location = new System.Drawing.Point(140, 35);
            this.dateTimePickerDataInicial.Name = "dateTimePickerDataInicial";
            this.dateTimePickerDataInicial.Size = new System.Drawing.Size(38, 20);
            this.dateTimePickerDataInicial.TabIndex = 24;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(136, 13);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(42, 17);
            this.radioButtonSim.TabIndex = 23;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(197, 13);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(45, 17);
            this.radioButtonNao.TabIndex = 22;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(282, 30);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 21;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonFiltrar.Location = new System.Drawing.Point(684, 12);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(104, 55);
            this.buttonFiltrar.TabIndex = 22;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = false;
            this.buttonFiltrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormImprimirAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButtonFeminino);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonArquivoTexto);
            this.Controls.Add(this.dataGridViewListaDeAlunos);
            this.Name = "FormImprimirAlunos";
            this.Text = "FormImprimirAlunos";
            this.Load += new System.EventHandler(this.FormImprimirAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeAlunos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaDeAlunos;
        private System.Windows.Forms.Button buttonArquivoTexto;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.RadioButton radioButtonNao;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFiltrar;
    }
}