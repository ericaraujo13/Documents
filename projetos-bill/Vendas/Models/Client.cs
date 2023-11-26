namespace Vendas.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public long Cpf { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string Endereco { get; set; }
    public List<Carrinho> Carrinhos { get; set; }
  }
}