namespace Facturacion.Models;

public class Pedido
{
    public string ArchivoImpresionRemito { get; set; }
    public string Cot { get; set; }
    public List<DatosAdicionales> DatosAdicionales { get; set; }
    public string FacturaLegal { get; set; }
    public string FechaDeFacturacion { get; set; }
    public string FechaEntrega { get; set; }
    public string LinkImpresionRemito { get; set; }
    public string NumeroOrdenExterna { get; set; }
    public string PrecioValorFc { get; set; }
    public string Propietario { get; set; }
    public string Remito { get; set; }
    public string TieneGestionCobranza { get; set; }
    public string ValorDeclarado { get; set; }
}