using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{   
    // para fazer a herança utilize dois pontos seguidos da classe que se quer herdar

    internal class PessoaFisica : Pessoa 
    {

        public string CPF { get; set; }

        public PessoaFisica(string nome, string sobrenome, string cpf) : base(nome, sobrenome)
        {
            this.CPF = cpf;
        }

        override
        public string Saudacao()
        {
            return base.Saudacao() + " - " + this.CPF;
        }
        
    }
}
