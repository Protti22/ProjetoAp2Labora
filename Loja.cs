public class Loja
{
    private List<Produto> Produtos { get; set; } = new List<Produto>();
    private List<Cliente> Clientes { get; set; } = new List<Cliente>();

    public void CadastrarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public Produto ConsultarProdutoPorCodigo(string codigo)
    {
        return Produtos.FirstOrDefault(p => p.Codigo == codigo);
    }

    public void ListarProdutos()
    {
        foreach (var produto in Produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Código: {produto.Codigo}, Preço: {produto.Preco}");
        }
    }

    public void CadastrarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
    }

    public Cliente ConsultarClientePorID(string numeroIdentificacao)
    {
        return Clientes.FirstOrDefault(c => c.NumeroIdentificacao == numeroIdentificacao);
    }

    public void ListarClientes()
    {
        foreach (var cliente in Clientes)
        {
            cliente.ExibirInformacoes();
        }
    }
}
