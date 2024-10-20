public class Pedido : ICarriavel
{
    public Cliente Cliente { get; set; }
    public DateTime DataPedido { get; private set; }
    public List<Produto> Produtos { get; private set; }
    public string Status { get; private set; }

    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
        DataPedido = DateTime.Now;
        Produtos = new List<Produto>();
        Status = "Em Andamento";
    }

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public void RemoverProduto(Produto produto)
    {
        Produtos.Remove(produto);
    }

    public decimal CalcularTotal()
    {
        return Produtos.Sum(produto => produto.CalcularPrecoFinal());
    }

    public void FinalizarPedido()
    {
        Status = "Concluído";
    }
}
