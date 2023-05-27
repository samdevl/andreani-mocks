using System.ComponentModel.DataAnnotations;

namespace Pedidos.Models;

public class PedidoRequest
{
    [Required]
    public string almacen { get; set; }
    [Required]
    public string contratoDistribucion { get; set; }
    [Required]
    public string contratoWarehouse { get; set; }
    [Required]
    public string instancia { get; set; }
    [Required]
    public Pedido pedido { get; set; }
}