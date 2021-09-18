using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20124_20137_Hash;

namespace _20124_20137_Hash
{
    public partial class Form1 : Form
    {

        SondagemLinear vetor = new SondagemLinear(25);
        public Form1()
        {
            InitializeComponent();
            atualizarDgv();
        }

        private void atualizarDgv()
        {
            dgvAluno.Rows.Clear();
            dgvAluno.RowCount = vetor.getTamanho();
            for (int i = 0; i < vetor.getTamanho(); i++)
            {
                if (vetor.getValor(i) != null)
                {
                    dgvAluno[0, i].Value = i.ToString();
                    dgvAluno[1, i].Value = vetor.getValor(i).getRa();
                    dgvAluno[2, i].Value = vetor.getValor(i).getNome();
                }
                else
                    dgvAluno[0, i].Value = i.ToString();

            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int x;
            if (Int32.TryParse(txtRa.Text, out x) && txtNome.Text != "")
            {
                vetor.adicionar(new Aluno(txtRa.Text, txtNome.Text));
            }
            else MessageBox.Show("RA inválido. Inclusão não efetuada");
            atualizarDgv();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int x;
            if (Int32.TryParse(txtRa.Text, out x) && txtNome.Text != "")
            {
                vetor.deletar(new Aluno(txtRa.Text, txtNome.Text));
            }
            else MessageBox.Show("RA inválido. Deleção não efetuada");
            atualizarDgv();
        }
    }
}
