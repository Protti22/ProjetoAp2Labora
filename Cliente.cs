public class Cliente
{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }

    public Cliente(string nome, string numeroidentificacao, string endereco, string contato)
    {
        Nome = nome;
        NumeroIdentificacao = numeroidentificacao;
        Endereco = endereco;
        Contato = contato;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Cliente: {Nome}, Numero de Indentificação(ID): {NumeroIdentificacao}, Endereço do cliente: {Endereco}, Contato do cliente: {Contato}");
    }

}