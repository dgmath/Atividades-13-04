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
    }
}