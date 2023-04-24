using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_de_Aluno
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public string idade;
        public string rg;
        public bool bolsista;
        public float mediaF;
        public float preçoMensalidade;

        public void Media()
        {
            Console.WriteLine($"Sua media final é {mediaF}");
        }

        public void Mensalidade()
        {
            if (bolsista == true && mediaF >= 8)
            {
                Console.WriteLine($"Sua mensalidade é {preçoMensalidade * 0.5F}");
            }
            else if (bolsista == true && mediaF > 6 && mediaF < 8)
            {
                Console.WriteLine($"Sua mensalidade é {preçoMensalidade * 0.3F}");
            }
            else
            {
                Console.WriteLine($"Sua mensalidade é {preçoMensalidade}");
            }

        }
    }
}