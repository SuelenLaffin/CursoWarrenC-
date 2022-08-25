using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class PessoaJuridicaRepository
    {
        // CRUD - Create, Read, Update, Delete

       
        private List<PessoaJuridica> pessoas;

        public PessoaJuridicaRepository()
        {
           
           this.pessoas= new List<PessoaJuridica>();
        }


        public string Create(PessoaJuridica pessoa)
        {
            this.pessoas.Add(pessoa);
            return "Pessoa Juridica: " + " " +   pessoa.Nome + ", "  + "salva com sucesso ";
        }
        public List<PessoaJuridica> Read()
        {   
            return pessoas;
        }
        public string Update(PessoaJuridica pessoa)
        {
            return "Pessoa Juridica: " + " " + pessoa.Nome + " alterada com sucesso";
        }
        public string Delete(int id)
        {
            return "Pessoa de id: " + " " +  id + "deletada com sucesso";
        }

        public string CreateJ(PessoaJuridica pessoa)
        {
            this.pessoas.Add(pessoa);
            return "Pessoa Juridica: " + " " + pessoa.Nome + ", " + "salva com sucesso ";
        }

       
    }
}
