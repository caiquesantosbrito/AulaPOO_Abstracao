namespace Abstracao.Classes
{
    public class Boleto : Pagamentos
    {
        private string codigoDeBarras;
        public string CodigoDeBarras{
            get{return codigoDeBarras;}
            set{codigoDeBarras = value;}
        }
        public void Registrar(string valor){
            this.codigoDeBarras = valor;
        }
        public override string Desconto(float valor){
            return $"Você terá R${valor*0.12} de desconto.\nO Preço final com desconto é de R${valor - valor*0.12}";
        }    
    }
}