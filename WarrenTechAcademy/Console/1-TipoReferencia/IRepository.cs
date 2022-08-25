using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal interface IRepository
    {
        // assinatura do método, define o tipo de retorno, o nome do método e os parâmetros de entrada
        string Create(Pessoa p);
        string Update(Pessoa p);
        string Delete(int id);
        List<Pessoa> Read(Pessoa p);
       
        

    }
}
