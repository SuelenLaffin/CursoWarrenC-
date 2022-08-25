using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    internal class BemVindo
    {
        public static void Mensagem() // passo argumentos e recebo parâmetros
        {
            System.Console.WriteLine("Hello World!");
            System.Console.WriteLine("Digite seu nome: ");
            string nome = System.Console.ReadLine();
            System.Console.WriteLine("Até breve, " + nome);
            System.Console.ReadLine();
        }
    }
}
