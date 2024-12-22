namespace bytebank_Modelos.bytebank.Modelos.ADM.Utilitario
{
    internal class AutenticacaoUtil
    {
        public bool ValidarSenha(string senhaverdadeira, string senhatentativa)
        {
            return senhaverdadeira.Equals(senhatentativa);
        }
    }
}