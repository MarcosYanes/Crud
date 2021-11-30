namespace CrudDesafio.Model
{
    public class CarrinhoProduto
    {
       public int IdPedido_produto { get; set; }
        public int IdPedido { get; set; }

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public double PrecoDeCusto { get; set; }
        public double PrecoVenda { get; set; }

        public double Desconto { get; set; }
        public int Quantidade { get; set; }
       
        public double Total
        {
            get => PrecoVenda * Quantidade;
        }
        public double PrecoLiquido
        {
            get => (PrecoVenda * Quantidade) - Desconto;
        }
        public double Lucro { get => (Total - (PrecoDeCusto * Quantidade) - Desconto); }
        //public CarrinhoProduto()
        //{
        //    Quantidade = 1;
        //}
    }
}
