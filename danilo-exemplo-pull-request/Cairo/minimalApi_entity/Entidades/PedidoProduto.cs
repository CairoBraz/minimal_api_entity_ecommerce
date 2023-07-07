namespace Cairo.Entidades;

public record PedidoProduto
{
    public int Id { get; set; }
    public int PedidoId { get; set; }
    public Pedido Pedido { get; set; } = default!;
    public int ProdutoId { get; set; }
    public Produto Produto { get; set; }
}