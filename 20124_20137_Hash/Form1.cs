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

        SondagemLinear vetor = new SondagemLinear(10);
        public Form1()
        {
            InitializeComponent();
            vetor.adicionar(new Aluno("20137", "Gustavo"));
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


                //dgvAluno.Rows.Add(i.ToString(), vetor.getValor(i).getRa(), vetor.getValor(i).getNome());
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //int x;
            /*if (Int32.TryParse(txtRa.Text, out x) && txtNome.Text != "")
            {
                vetor.adicionar(new Aluno(txtRa.Text, txtNome.Text));
            }*/
            vetor.adicionar(new Aluno(txtRa.Text, txtNome.Text));
            atualizarDgv();
        }
    }
}
