namespace PilaresOOP
{
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;

        protected Eletrodomestico(string nome, int _voltagem)
        {
            _nome = nome;
            _voltagem = _voltagem;
        }

        public abstract void Ligar();
        public abstract void Desligar();
    }
}