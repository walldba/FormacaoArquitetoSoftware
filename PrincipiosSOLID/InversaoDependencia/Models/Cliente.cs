namespace InversaoDependencia.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        public bool Validar()
        {
            //Criar validação de CPF e EMAIL
            return true;
        }
    }
}