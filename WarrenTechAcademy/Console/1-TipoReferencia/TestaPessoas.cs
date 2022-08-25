using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class TestaPessoas

    {
        public static void ExecutaPessoa()
        {
            Pessoa p = new Pessoa("Suelen", "Laffin");
            Pessoa pf = new PessoaFisica("N", "S", "cpf");
            Pessoa pj = new PessoaJuridica("N", "S", "cnpj");

            PessoaFisica pf2 = (PessoaFisica)pf;
            PessoaJuridica pj2 = (PessoaJuridica)pj;

            System.Console.WriteLine(p.Saudacao());
            System.Console.WriteLine(pf.Saudacao());
            System.Console.WriteLine(pj.Saudacao());
        }

        public static void ExecutaFisica()
        {
            PessoaFisica pessoaFisica = new PessoaFisica("Suelen", "Laffin", "0005255025");
            PessoaFisica pessoaFisica2 = new PessoaFisica("Gabrielle", "Laffin", "0005254845");
            


            PessoaFisicaRepository repository = new PessoaFisicaRepository();
            string msg = repository.Create(pessoaFisica);
            System.Console.WriteLine(msg);

            repository.Create(pessoaFisica2);

            


            List<PessoaFisica> pessoas = repository.Read();

            foreach (var p in pessoas) // uma pessoa da lista de pessoas
            {
                System.Console.WriteLine(p.Saudacao());
            }

            System.Console.Read();
        }
        public static void ExecutaJuridica()
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica("Warren", "Invest", "00588624633"); 
            PessoaJuridica pessoaJuridica2 = new PessoaJuridica("Rico", "Invest", "001478687424");

            PessoaJuridicaRepository repository = new PessoaJuridicaRepository();
            repository.Create(pessoaJuridica2);
            string msg = repository.Create(pessoaJuridica);
            System.Console.Write(msg);


            List<PessoaJuridica> pessoas = repository.Read();

            foreach (var p in pessoas) // uma pessoa da lista de pessoas
            {
                System.Console.WriteLine(p.Saudacao());
            }

            System.Console.Read();
        }
    }
}
