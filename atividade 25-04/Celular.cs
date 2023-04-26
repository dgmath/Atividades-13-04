namespace atividade_25_04
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;

        public void Ligar()
        {
            Console.WriteLine($"Ligando...");
        }
        public void Desligar()
        {
            Console.WriteLine($"Desligando...");
        }
        public void FazerLigacao()
        {
            Console.WriteLine($"Fazendo ligação...");
        }
        public void EnviarMensagem()
        {
            Console.WriteLine($"Enviando mensagem...");
        }

        public void Inicio()
        {
            if (ligado == true)
            {
             volta:
                Console.WriteLine($@"
                ---------------------------------------
                |  Bem vindo. Selecione oque deseja:  |
                |  [1] - Fazer ligação                |
                |  [2] - Enviar mensagem              |
                |  [0] - Desligar                     |
                ---------------------------------------
                ");
                string selecao = Console.ReadLine()!;
                switch (selecao)
                {
                    case "1":
                        FazerLigacao();
                        break;
                    case "2":
                        EnviarMensagem();
                        break;
                    case "0":
                        Desligar();
                        break;

                    default:
                        Console.WriteLine($"Por favor insira algo valido.");
                        goto volta;
                }
            }




























        }
    }
}