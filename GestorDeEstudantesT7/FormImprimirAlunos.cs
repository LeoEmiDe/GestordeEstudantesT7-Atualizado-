using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class FormImprimirAlunos : Form
    {
        public FormImprimirAlunos()
        {
            InitializeComponent();
        }

        Estudante Estudante = new Estudante();

        private void FormImprimirAlunos_Load(object sender, EventArgs e)
        {
            preencheTabela (new MySqlCommand("SELECT * FROM `estudantes`"));

            if (radioButtonNao.Checked == true)
            {
                dateTimePickerDataInicial.Enabled = false;
                dateTimePickerDataFinal.Enabled = false;
            }
        }

        public void preencheTabela(MySqlCommand comando)
        {
            // Impede que os dados exibidos na tabela sejam alterados.
            dataGridViewListaDeAlunos.ReadOnly = true;
            // Cria uma coluna para exibir as fotos dos alunos.
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            // Determina uma altura padrão para as linhas da tabela.
            dataGridViewListaDeAlunos.RowTemplate.Height = 80;
            // Determina a origem dos dados da tabela.
            dataGridViewListaDeAlunos.DataSource = Estudante.getEstudantes(comando);
            // Determinar qual SERÁ a coluna com as imagens.
            colunaDeFotos = (DataGridViewImageColumn)dataGridViewListaDeAlunos.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            // Impede o usuário de incluir linhas.
            dataGridViewListaDeAlunos.AllowUserToAddRows = false;

            // Mostra o total de alunos
            //labelTotalDeAlunos.Text = "Total de Alunos: " + dataGridViewListaDeAlunos.Rows.Count;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Filtra os dados que serão exibidos na tabela
            MySqlCommand comando;
            string busca;

            // Verificar se o usuário quer usar um intervalo de datas
            if (radioButtonSim. Checked == true)
            {
                // Pega as datas que o usuário selecionou
                string dataInicial = dateTimePickerDataInicial.Value.ToString("dd/mm/yyyy");
                string dataFinal = dateTimePickerDataFinal.Value.ToString("dd/mm/yyyy");

                if (radioButtonMasculino.Checked)
                {
                    busca = "Select * FROM `estudantes` WHERE `nascimento` BETWEEN"
                        + dataInicial + "' AND '"
                        + dataFinal + "' AND genero = 'Masculino'";
                }
                else if (radioButtonFeminino.Checked)
                {
                    busca = "Select * FROM `estudantes` WHERE `nascimento` BETWEEN"
                       + dataInicial + "' AND '"
                       + dataFinal + "' AND genero = 'Feminino'";
                }
                else
                {
                    busca = "Select * FROM `estudantes` WHERE `nascimento` BETWEEN"
                      + dataInicial + "' AND '"
                      + dataFinal + "'";
                }

                comando = new MySqlCommand(busca);
                preencheTabela(comando); 
            }
        }

        private void buttonArquivoTexto_Click(object sender, EventArgs e)
        {
            // Salva o arquivo em arquivo de texto.
            // por padrão vai salvar na área de trabalho.
            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\lista_de_estudantes.txt";

            // usamos isso somente ao salvar em arquivo de texto.
            using (var escritor = new StreamWriter(caminho))
            {
                // verifica se o arquivo de texto já existe
                if (!File.Exists(caminho))
                {
                    File.Create(caminho);
                }

                DateTime datadeNascimento;

                // percorre as linhas
                for (int i = 0; i < dataGridViewListaDeAlunos.Rows.Count; i++)

                    //percorre as colunas 
                    for (int j = 0; j < dataGridViewListaDeAlunos.Columns.Count; j++)
                    {
                        if (j == 3)
                        {
                            datadeNascimento = Convert.ToDateTime(dataGridViewListaDeAlunos.Rows[i].Cells[j].Value);
                            // escreve as informações de cada coluna (célula) de uma mesma linha.
                            escritor.Write("\t" + dataGridViewListaDeAlunos.Rows[i].Cells[j].Value
                                + "\t" + "|");
                        }
                        else if (j == dataGridViewListaDeAlunos.Columns.Count - 2)
                        {
                            escritor.Write('\t');
                            dataGridViewListaDeAlunos.Rows[i].Cells[j].Value.ToString();
                        }
                        else

                        {
                            // escreve as informações de cada coluna (célula) de uma mesma linha.
                            escritor.Write("\t" + dataGridViewListaDeAlunos.Rows[i].Cells[j].Value
                                + "\t" + "|");
                        }

                }

                escritor.Close();
                MessageBox.Show("Dados Salvos");

            }
        }
    }
}
    