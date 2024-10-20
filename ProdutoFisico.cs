public class ProdutoFisico : Produto
{
    public double Peso { get; set; }
    public Dimensoes Dimensoes { get; set; }
    public string Categoria { get; set; }

    public ProdutoFisico(string nome, string codigo, decimal preco, double peso, Dimensoes dimensoes, string categoria) : base(nome, codigo, preco)
    {
        Peso = peso;
        Categoria = categoria;
        Dimensoes = dimensoes;
    }

    public override decimal CalcularPrecoFinal()
    {
        double valorPorKg = 5;
        decimal taxaDeImpostos = Preco * 0.1m; //10%
        decimal custoEnvio = (decimal)(Peso * valorPorKg); //peso do produto
        decimal desconto = Preco * 0.05m;
        return Preco + taxaDeImpostos + custoEnvio - desconto;
    }

}

public class Dimensoes
{
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double Profundidade { get; set; }

    public Dimensoes(double altura, double largura, double profundidade)
    {
        Altura = altura;
        Largura = largura;
        Profundidade = profundidade;
    }
}