using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class Estruturas
    {
        public static void Executa()
        {
            int idade = 10;
            PessoaClass p1 = new PessoaClass();
            PessoaStruct p2 = new PessoaStruct();
            p2.Nome = "Joelma";
            p1.Nome = "Chimbinha";
            //System.Console.WriteLine(p1.Nome);
            //System.Console.WriteLine(p2.Nome);

            PessoaClass p3 = new PessoaClass();
            p3 = p1;
            PessoaStruct p4 = new PessoaStruct();
            p4 = p2;
            //System.Console.WriteLine(p3.Nome);
            //System.Console.WriteLine(p4.Nome);
            p1.Nome = "Chimbinha vacilou";
            p2.Nome = "Joelma melhor dançarina";
            System.Console.WriteLine(p1.Nome);
            System.Console.WriteLine(p2.Nome);
            System.Console.WriteLine(p3.Nome);
            System.Console.WriteLine(p4.Nome);




        }

        struct PessoaStruct
        {
            public int Id { get; set; }

            public string Nome { get; set; }

            public string Sobrenome { get; set; }

        }

        class PessoaClass
        {
            public int Id { get; set; } // get seria para pegar o valor, o set serve para atribuir o valor

            public string Nome { get; set; } // sempre começar um método com letra maiuscula

            public string Sobrenome { get; set; }// public consegue ser acessado de fora da classe, 

            private byte Idade { get; set; }
            public string nome;
            public string sobrenome;
            private byte idade; // private não pode ser acessado de fora

            //public string GetName()

            //{
            // return this.nome; // pode ser usado com this ou sem
            // }
            //public void SetNome(string nome)
            //{
            // this.nome = nome;
            // }

        }
    }
}
