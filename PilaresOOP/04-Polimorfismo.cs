namespace PilaresOOP
{
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
        : base(nome, voltagem) { }

        public CafeteiraEspressa()
       : base("Padrao", 220) { }

        private static void AquecerAgua() { }
        private static void MoerGraos() { }
        private static void PrepararCafe()
        {
            AquecerAgua();
            MoerGraos();
        }

        public override void Ligar()
        {

        }

        public override void Desligar()
        {

        }
    }
}