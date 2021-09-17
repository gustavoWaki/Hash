using System;
using System.Collections.Generic;
using System.Text;

namespace _20124_20137_Hash
{
    class Aluno
    {
        string ra, nome;

        public Aluno(string _ra, string _nome)
        {
            ra = _ra;
            nome = _nome;
        }

        public Aluno(string linhaLida)
        {
            ra = linhaLida.Substring(0, 5);
            nome = linhaLida.Substring(5);
        }

        public string getRa()
        {
            return ra;
        }

        public string getNome()
        {
            return nome;
        }

        public void setRa(string _ra)
        {
            if(_ra == "" || _ra == null)
            {
                throw new Exception("RA inválido!");
            }
            else
            ra = _ra;
        }

        public void setNome(string _nome)
        {
            if (_nome == "" || _nome == null)
            {
                throw new Exception("Nome inválido!");
            }
            else
                nome = _nome;
        }

        public string toString()
        {
            return ra + " " + nome;
        }
    }
}
