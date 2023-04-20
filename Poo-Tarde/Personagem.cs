using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo_Tarde
{
    public class Personagem
    {
        public string nome;
        
        public int idade;

        public string armadura;

        public string ia;

        public void Atacar()
        {
            Console.WriteLine($"O personagem atacou!");
            
        }

        public void Defender()
        {
            Console.WriteLine($"O personagem Defendeu!");
        }

        public void ResturarArmadura()
        {
            Console.WriteLine($"O personagem restaurou a armadura!");
            
        }
    }
}

