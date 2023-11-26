namespace namespace Vendas.Models
{
  public class Produto
  {
    public int ProdutoId { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public List<Carrinho> Carrinhos { get; set; }
  }
}