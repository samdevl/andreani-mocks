using System.ComponentModel.DataAnnotations;

namespace Facturacion.Models;

public class FacturacionRequest
{
    [Required]
    public string Almacen { get; set; }
    [Required]
    public string ContratoDistribucion { get; set; }
    [Required]
    public string Instancia { get; set; }
    [Required]
    public Pedido Pedido { get; set; }
}