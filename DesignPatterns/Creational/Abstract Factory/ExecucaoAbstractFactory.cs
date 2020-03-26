using System.Collections.Generic;

namespace DesignPatterns.Creational.Abstract_Factory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var veiculosSocorro = new List<Veiculo>
            {
                VeiculoCreator.Criar("Celta", Porte.Pequeno),
                VeiculoCreator.Criar("Jetta", Porte.Medio),
                VeiculoCreator.Criar("BMW X6", Porte.Grande)
            };

            veiculosSocorro.ForEach(v => AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento());
        }
    }
}