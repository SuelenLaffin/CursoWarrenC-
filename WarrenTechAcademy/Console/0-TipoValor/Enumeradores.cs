using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class Enumeradores
    {
        public static void Executa()
        {   // você cria um enum fora do método, depois acessa os valores pelo enum.
            System.Console.WriteLine(DiasDaSemana.DOM);
            System.Console.WriteLine((byte)DiasDaSemana.DOM);
            System.Console.WriteLine((int)DiasDaSemana.SEX);

            DiasDaSemana seg = DiasDaSemana.SEG;
            System.Console.WriteLine(seg);
            DiasDaSemana ter = (DiasDaSemana)2;
            System.Console.WriteLine(ter);
        }
    }

    public enum DiasDaSemana
    { 
        DOM,
        SEG,
        TER,
        QUA,
        QUI,
        SEX,
        SAB
    }

}
