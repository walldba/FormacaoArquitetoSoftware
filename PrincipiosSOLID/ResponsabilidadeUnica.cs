using System;

namespace PrincipiosSOLID
{
    public class ResponsabilidadeUnica
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar()
        {
            //O Cliente deve ser capaz de validar seus dados, como CPF, Email...
        }
    }
}
