//Criar Loja
Loja minhaLoja = new Loja();

// Criar produto
ProdutoFisico produtoFisico = new ProdutoFisico("Celular", "NARTHUR", 3000.00m, 0.4, new Dimensoes(17, 7, 0.5), "Eletrônicos");
ProdutoDigital produtoDigital = new ProdutoDigital("Musica", "3882926", 10.00m, 0.8, "MP4");

// Cadastro de produto
minhaLoja.CadastrarProduto(produtoFisico);
minhaLoja.CadastrarProduto(produtoDigital);

// Fazer modelo de cliente
Cliente cliente = new Cliente("Jose Junior", "AV211111", "Rua Avenida, 2007", "juniorjose@gmail.com");

// Criar pedido
Pedido pedido = new Pedido(cliente);
pedido.AdicionarProduto(produtoFisico);
pedido.AdicionarProduto(produtoDigital);

// Finalizando
decimal total = pedido.CalcularTotal();
Console.WriteLine($"Total do pedido: {total:C}");
pedido.FinalizarPedido();

// exibindo informações
minhaLoja.ListarProdutos();
minhaLoja.ListarClientes();