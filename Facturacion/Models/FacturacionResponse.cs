namespace Facturacion.Models;

public class FacturacionResponse
{
    public string Estado { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }
    public string Razon { get; set; }
    public Request Request { get; set; }
    public Response Response { get; set; }
}