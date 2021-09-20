using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20124_20137_Hash
{
    class SondagemLinear
    {
        private int tamanho;
        ListaLigada<Aluno> dados;
        public int Tamanho { get => tamanho; }

        public SondagemLinear (int _tamanho)
        {
            tamanho = _tamanho;
            dados = new ListaLigada<Aluno>(tamanho);
        }

        public void adicionar (Aluno aluno)
        {
            if(aluno == null)
            {
                throw new Exception("Falha ao adicionar");
            }

            if (dados.isCheio())
            {
                MessageBox.Show("Vetor está cheio. Inclusão não efetuada");
                return;
            }
                

            int pos = Hash(aluno.getRa());

            pos = pos % dados.getTamanho();

            if(dados.getValor(pos) == null)
                dados.setValor(aluno, pos);
            else if(dados.getValor(pos).getRa() == aluno.getRa())
            {
                MessageBox.Show("RA já existente. Inclusão não efetuada");
            }
            else
            {
                Aluno al;

                for(int i = pos + 1; i%dados.getTamanho() != pos; i++)
                {
                    al = dados.getValor(i % dados.getTamanho());
                    if (al == null)
                    {
                        dados.setValor(aluno, i % dados.getTamanho());
                        return;
                    }
                    else if (al.getRa() == aluno.getRa())
                    {
                        MessageBox.Show("RA já existente. Inclusão não efetuada");
                    }
                    
                }MessageBox.Show("Vetor está cheio. Inclusão não efetuada");
                
            }
        }

        public void deletar(Aluno aluno)
        {
            if (aluno == null)
            {
                throw new Exception("Falha ao deletar");
            }

            if (dados.getLength() == 0)
            {
                MessageBox.Show("Vetor está vazio. Deleção não efetuada");
                return;
            }

            int pos = Hash(aluno.getRa());

            pos = pos % dados.getTamanho();

            if(dados.getValor(pos) == null)
            {
                MessageBox.Show("RA não encontrado. Deleção não efetuada.");
                return;
            }
                

            if (dados.getValor(pos).getRa() == aluno.getRa())
                dados.deletar(null, pos);
            else
            {
                Aluno al;

                for (int i = pos + 1; i % dados.getTamanho() != pos; i++)
                {
                    al = dados.getValor(i % dados.getTamanho());
                    if(al == null)
                    {
                        continue;
                    }
                    if (al.getRa() == aluno.getRa())
                    {
                        dados.deletar(null, i % dados.getTamanho());
                        return;
                    }
                }
                MessageBox.Show("RA não encontrado. Deleção não efetuada.");

            }
        }

        public int Hash(string chave)
        {
            int hash = 1;
            for (int i = 0; i < chave.Length; i++)
            {
                hash = 17 * hash * (char)chave[i];
            }
            int soma = 0;
            for(int i = 0; i<chave.Length; i++)
            {
                soma += int.Parse(chave[i].ToString());
            }
            hash *= 11 * soma;

            if (hash < 0)
                hash = -hash;

            return hash;
        }

        public int getLength()
        {
            return dados.getLength();
        }

        public Aluno getValor(int pos)
        {
            return dados.getValor(pos);
        }

        public int getTamanho()
        {
            return dados.getTamanho();
        }
    }
}
