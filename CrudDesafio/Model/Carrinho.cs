namespace CrudDesafio.Model
{
    public class Carrinho
    {
        public int IdProduto { get; set; }
        public string  NomeProduto { get; set; }
        public double PrecoVenda { get; set; }
        
        public double Desconto { get; set; }
        public int Quantidade { get; set; }
        public double PrecoLiquido { get; set; }

        public Carrinho()
        {
            Quantidade = 1;
        }
    }
}
