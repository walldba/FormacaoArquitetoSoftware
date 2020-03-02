namespace PrincipiosSOLID.AbertoFechado
{
    public class DebitoContaSalario : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            return FormatarTransacao();
        }
    }
}