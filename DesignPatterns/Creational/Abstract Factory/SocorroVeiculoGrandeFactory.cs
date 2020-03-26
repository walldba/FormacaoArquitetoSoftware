namespace DesignPatterns.Creational.Abstract_Factory
{
    public class SocorroVeiculoGrandeFactory : AutoSocorroFactory
    {
        public override Guincho CriarGuincho()
         => GuinchoCreator.Criar(Porte.Pequeno);

        public override Veiculo CriarVeiculo(string modelo, Porte porte)
         => VeiculoCreator.Criar(modelo, porte);
    }
}