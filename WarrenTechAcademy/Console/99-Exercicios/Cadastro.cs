using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._99_Exercicios
{
    internal class Cadastro
    {
        // Crie um sistema de cadastro de pessoas
        // 1 - O sistema deve exibir uma mensagem de boas vindas
        // 2 - Deve solicitar as seguintes informações ao usuário:
        // Nome, Sobrenome e Idade
        // 3 - Ao fim da execução, deve exibir o nome completo e idade, juntamente com a mensagem de despedida

        public static void Executa()

        {
            System.Console.WriteLine("Olá!");
            System.Console.Write("Digite seu nome: "); // se colocar o Write, escreverá na mesma linha, o WriteLine escreverá na linha
            // debaixo
            string nome = System.Console.ReadLine();

            System.Console.WriteLine("Digite seu sobrenome: ");
            string sobrenome = System.Console.ReadLine();

            System.Console.WriteLine("Seja bem vindo! " + nome);

            System.Console.WriteLine("Qual a sua idade: ");
            byte idade = byte.Parse(System.Console.ReadLine());
            

            System.Console.WriteLine("Até breve " + nome +  " " + sobrenome + " "  + idade + "anos");
            System.Console.ReadLine();

        }
    }
    }
