using InversaoDependencia.Interfaces;

namespace InversaoDependencia
{
    public class EmailServices : IEmailServices
    {
        public void Enviar(string de, string para, string assunto, string mensagem)
        {
            throw new System.NotImplementedException();
        }
    }
}