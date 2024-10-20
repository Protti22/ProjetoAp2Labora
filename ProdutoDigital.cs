public class ProdutoDigital : Produto
{
    public double TamanhoArquivo { get; set; }
    public string Formato { get; set; }

    public ProdutoDigital(string nome, string codigo, decimal preco, double tamanhoarquivo, string formato) : base(nome, codigo, preco)
    {
        TamanhoArquivo = tamanhoarquivo;
        Formato = formato;
    }

    public override decimal CalcularPrecoFinal()
    {
        decimal desconto = Preco * 0.1m;
        return Preco - desconto;

    }
}