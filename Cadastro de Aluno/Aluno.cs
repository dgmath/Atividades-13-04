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
        public bool bolsista = false;
        public float mediaF;
        public float ValorMensalidade;

        public void Media()
        {
            Console.WriteLine($"Sua media final é {this.mediaF}");
        }
        // public float Mensalidade()
        // {
        //     float valor;

        //     if(this.bolsista && this.mediaF >= 8)
        //     {
        //          valor = this.ValorMensalidade * 0.5f;
        //     }
        //     else if (this.bolsista && this.mediaF > 6)
        //     {
        //         valor = this.ValorMensalidade * 0.7f;
        //     }
        //     else
        //     {
        //        valor = this.ValorMensalidade;
        //     }

        //     return valor;

        //}
         public void Mensalidade()
         {
             if (bolsista == true && mediaF >= 8)
             {
                 Console.WriteLine($"Sua mensalidade é {(this.ValorMensalidade * 0.5F).ToString("C", new System.Globalization.CultureInfo("pt-BR"))}");
             }
             else if (bolsista == true && mediaF > 6 && mediaF < 8)
             {
                 Console.WriteLine($"Sua mensalidade é {(this.ValorMensalidade * 0.3F).ToString("C", new System.Globalization.CultureInfo("pt-BR"))}");
             }
             else
             {
                 Console.WriteLine($"Sua mensalidade é {this.ValorMensalidade.ToString("C", new System.Globalization.CultureInfo("pt-BR"))}");
             }
         }


    }
}