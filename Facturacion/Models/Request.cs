namespace Facturacion.Models;

public class Request
{
    public string Almacen { get; set; }
    public string ContratoDistribucion { get; set; }
    public string Instancia { get; set; }
    public Pedido Pedido { get; set; }
}