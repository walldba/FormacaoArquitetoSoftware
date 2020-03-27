namespace DesignPatterns.Structural.Adapter
{
    public class ExecucaoAdapter
    {
        public static void Executar()
        {
            //TODO: Resolver com Injeção de Dependência..
            var pagamentoLogPadrao = new TransacaoService(new Logger());
            pagamentoLogPadrao.RealizarTransacao();

            var pagamentoLogCustom = new TransacaoService(new LogAdapter(new LogNetMasterService()));
            pagamentoLogCustom.RealizarTransacao();
        }
    }
}