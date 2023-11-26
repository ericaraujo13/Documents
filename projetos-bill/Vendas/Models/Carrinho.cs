namespace Vendas.Models
{
  public class Carrinho
  {
    public int CarrinhoId { get; set; }
    public int ClientId { get; set; }
    public Client Client { get; set; }
    public List<ItemCarrinho> ItensCarrinho { get; set; }
  }
}