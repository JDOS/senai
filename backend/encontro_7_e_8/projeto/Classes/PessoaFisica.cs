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
        public DateTime dataNasc {get;set;}

// - Pessoa física
// Para rendimentos até 1500, isento
// Para rendimentos entre 1500 e 3500, 2%
// Para rendimentos entre 3500 e 6000, 3,5%
// para rendimentos acima de 6000, 5%
        public override float CalcularImposto(float rendimento)
        {
            if(rendimento <= 1500){
                return 0;
            }
            else if(rendimento > 1500 && rendimento <= 3500 ){
                float result = (rendimento/100) * 2;
                return result;
            }
            else if(rendimento > 3500 && rendimento <= 6000 ){
                float result = (rendimento/100) * 3.5f;
                return result;
            }
            else{
                float result = (rendimento/100) * 5;
                return result;
            }
   

            throw new NotImplementedException();
        }

        public bool validarDataNasc(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            var anos = (dataAtual - dataNasc).TotalDays/365;
            Console.WriteLine(anos);

            if (anos>=18){
                return true;
            }
            else{
                return false;
            }
     
        }
        public bool validarDataNasc(String dataNasc)
        {
            DateTime.TryParse(dataNasc, out DateTime dataConvertida);

            DateTime dataAtual = DateTime.Today;
            var anos = (dataAtual - dataConvertida).TotalDays/365;
            Console.WriteLine(anos);

            if (anos>=18){
                return true;
            }
            else{
                return false;
            }
     
           
        }
    }
}