using bytebank.Modelos.ADM.SistemaInterno;
using bytebank_Modelos.bytebank.Modelos.ADM.Utilitario;

namespace bytebank.Modelos.ADM.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public AutenticacaoUtil Autenticator { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Autenticator.ValidarSenha(this.Senha, senha);
        }
    }
}
