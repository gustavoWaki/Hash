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

        Pessoa[] vetor = new Pessoa[10];
        public Form1()
        {
            InitializeComponent();
            Pessoa gustavo = new Pessoa("20137", "Gustavo");
            Pessoa artur = new Pessoa("20124", "Artur");
            vetor[0] = gustavo;
            vetor[1] = artur;
            preencherDgv(vetor);
        }

        private void preencherDgv(Pessoa[] vetor)
        {
            dgvPessoa.Rows.Clear();
            for (int i = 0; i < 2; i++)
            {
                dgvPessoa.Rows.Add(i.ToString(), vetor[i].Chave, vetor[i].Nome);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            preencherDgv(vetor);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            vetor[2] = new Pessoa("12345", "Pedro");
        }
    }
}
