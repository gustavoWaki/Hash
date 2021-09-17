using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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

            int hash = 1;
            for(int i = 0; i < aluno.getRa().Length; i++)
            {
                hash = 17 * hash * (char)aluno.getRa()[i];
            }
            hash *= aluno.getRa().Length * 31;

            for (int i = 0; i < aluno.getNome().Length; i++)
            {
                hash = 19 * hash * (char)aluno.getNome()[i];
            }
            hash *= aluno.getNome().Length * 13;

            if (hash < 0)
                hash *= -1;

            hash = hash % dados.getTamanho();

            if(dados.getValor(hash) == null)
                dados.setValor(aluno, hash);
            else
            {
                Aluno al;

                for(int i = hash+1; i%dados.getTamanho() != hash; i++)
                {
                    al = dados.getValor(i % dados.getTamanho());
                    if (al == null)
                    {
                        dados.setValor(aluno, i % dados.getTamanho());
                        return;
                    }
                }
                
            }
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
