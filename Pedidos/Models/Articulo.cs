using System.ComponentModel.DataAnnotations;

namespace Pedidos.Models;

public class Articulo
{
    [Required]
    public int cantidad { get; set; }
    [Required]
    public string codigo { get; set; }
    public Lote lote { get; set; }
    public string numeroDePedido { get; set; }
    [Required]
    public string propietario { get; set; }
    [Required]
    public string unidadDeMedida { get; set; }
    public string zonaConsumo { get; set; }
}
