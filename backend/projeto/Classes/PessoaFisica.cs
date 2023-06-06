using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto.Interfaces;

namespace projeto.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string?cpf {get;set;}
        public DateTime? dataNasc {get;set;}

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool validarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}