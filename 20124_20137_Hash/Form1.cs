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

        SondagemLinear vetor = new SondagemLinear(29);
        SondagemQuadratica vetor2 = new SondagemQuadratica(29);
        byte tipo = 1;
        public Form1()
        {
            InitializeComponent();
            atualizarDgv();
        }

        private void atualizarDgv()
        {
            if(tipo == 1) 
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
            else if(tipo == 2){
                dgvAluno.Rows.Clear();
                dgvAluno.RowCount = vetor2.getTamanho();
                for (int i = 0; i < vetor2.getTamanho(); i++)
                {
                    if (vetor2.getValor(i) != null)
                    {
                        dgvAluno[0, i].Value = i.ToString();
                        dgvAluno[1, i].Value = vetor2.getValor(i).getRa();
                        dgvAluno[2, i].Value = vetor2.getValor(i).getNome();
                    }
                    else
                        dgvAluno[0, i].Value = i.ToString();

                }
            }
            else if (tipo == 3)
            {
                dgvAluno.Rows.Clear();
                dgvAluno.RowCount = vetor2.getTamanho();
                for (int i = 0; i < vetor2.getTamanho(); i++)
                {
                    if (vetor.getValor(i) != null)
                    {
                        dgvAluno[0, i].Value = i.ToString();
                        dgvAluno[1, i].Value = vetor2.getValor(i).getRa();
                        dgvAluno[2, i].Value = vetor2.getValor(i).getNome();
                    }
                    else
                        dgvAluno[0, i].Value = i.ToString();

                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int x;
            if (Int32.TryParse(txtRa.Text, out x) && txtNome.Text != "")
            {
                if(tipo == 1)
                vetor.adicionar(new Aluno(txtRa.Text, txtNome.Text));
                else if(tipo ==2)
                    vetor2.adicionar(new Aluno(txtRa.Text, txtNome.Text));
            }
            else MessageBox.Show("RA inválido. Inclusão não efetuada");
            atualizarDgv();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int x;
            if (Int32.TryParse(txtRa.Text, out x) && txtNome.Text != "")
            {
                if (tipo == 1)
                    vetor.deletar(new Aluno(txtRa.Text, txtNome.Text));
                else if (tipo == 2)
                    vetor2.deletar(new Aluno(txtRa.Text, txtNome.Text));
            }
            else MessageBox.Show("RA inválido. Deleção não efetuada");
            atualizarDgv();
        }

        private void rbLin_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 1;
            atualizarDgv();
        }

        private void rbQuad_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 2;
            atualizarDgv();
        }

        private void rbDuplo_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 3;
            atualizarDgv();
        }
    }
}
