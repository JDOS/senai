using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using projeto.Interfaces;

namespace projeto.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj {get;set;}
        public string? razaoSocial{get;set;}
        public string? Caminho {get; private set;} = "Database/PessoaJurica.csv";
// Para Rendimentos até 3000, 3%
// Para rendimentos entre 3000 e 6000, 5%
// Para rendimentos entre 6000 e 10000, 7%
// Para rendimentos acima de 10000, 9%
        public override float CalcularImposto(float rendimento)
        {
            if(rendimento <= 3000){
                float result = (rendimento/100) * 3;
                return 0;
            }
            else if(rendimento > 3000 && rendimento <= 6000 ){
                float result = (rendimento/100) * 5;
                return result;
            }
            else if(rendimento > 6000 && rendimento <= 100000 ){
                float result = (rendimento/100) * 7;
                return result;
            }
            else{
                float result = (rendimento/100) * 9;
                return result;
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            // cnpj e regex
            bool result = Regex.IsMatch(cnpj, @"^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$");
            
            if (result){
                string subCnpj = cnpj.Substring(8,4);
                // Console.WriteLine(subcnpj);
                if (subCnpj=="0001"){
                    return true;
                }     
            }
            
            string subcnpj = cnpj.Substring(11,4);
                // Console.WriteLine(subcnpj);
                if (subcnpj=="0001"){
                    return true;
                }
          

                return false;
        
        }

        public void Inserir(PessoaJuridica pj){
            
            Utils.VerificarPastaArquivo(Caminho);

            string [] pjstring = {$"{pj.razaoSocial},{pj.cnpj}"};

            File.AppendAllLines(Caminho, pjstring);
        }

        public List<PessoaJuridica> LerArquivo()
        {
            //razao social, cnpj
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();
            
            string [] linhas = File.ReadAllLines(Caminho);

            foreach (string cadaLinha in linhas)
            {
                string [] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.razaoSocial = atributos[0];
                cadaPj.cnpj = atributos[1];
                
                listaPj.Add(cadaPj);

            }

            return listaPj;
        }

    }
}