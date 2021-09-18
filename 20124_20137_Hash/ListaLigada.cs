using System;
using System.Collections.Generic;
using System.Text;

namespace _20124_20137_Hash
{
    class ListaLigada<X>
    {
        class No
        {
            private No proximo;
            private X dados;
            private int pos;

            public No(No prox, X dado, int _pos)
            {
                proximo = prox;
                dados = dado;
                _pos = _pos;
            }
            public No(int _pos)
            {
                pos = _pos;
            }

            public void setDados(X dado)
            {
                dados = dado;
            }

            public X getDados()
            {
                return dados;
            }

            public void setProximo(No prox)
            {
                proximo = prox;
            }

            public No getProximo()
            {
                return proximo;
            }

        }

        No[] lista;
        int tamanho;
        int quantos;

        public ListaLigada(int _tamanho)
        {
            tamanho = _tamanho;
            lista = new No[tamanho];

            for(int i = 0; i < tamanho; i++)
            {
                lista[i] = new No(i);
            }

            for (int i = 0; i < tamanho-1; i++)
            {
                lista[i].setProximo(lista[i+1]);
            }

            lista[tamanho - 1].setProximo(lista[0]);
        }

        public void setValor(X dado, int pos)
        {
            if(dado == null)
            {
                throw new Exception("Dado inválido!");
            }

            lista[pos].setDados(dado);
            quantos++;
        }

        public void deletar(X dado, int pos)
        {
            lista[pos].setDados(dado);
            quantos--;
        }

        public X getValor(int pos)
        {
            return lista[pos].getDados();
        }

        public X getProxValor(int pos)
        {
            return lista[pos].getProximo().getDados();
        }

        public int getTamanho()
        {
            return tamanho;
        }

        public int getLength()
        {
            return quantos;
        }

    }
}
