using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class TipoNumerico2
    {
        public static void  Executa()
        {
            // char é um tipo númerico inteiro
            char letra = 'S';
            System.Console.WriteLine("Char: " + letra);
            char charMin = char.MinValue;
            char charMax = char.MaxValue;
            System.Console.WriteLine("Char min: " + charMin);
            System.Console.WriteLine("Char max: " + charMax);

            System.Console.WriteLine("Letra S: " + (byte)letra);
        }
    }
}
