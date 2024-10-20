public abstract class Produto
{
    public string Nome { set; get; }
    public string Codigo { set; get; }
    public decimal Preco { set; get; }

    public Produto(string nome, string codigo, decimal preco)
    {
        Nome = nome;
        Codigo = codigo;
        Preco = preco;
    }

    public abstract decimal CalcularPrecoFinal();

}