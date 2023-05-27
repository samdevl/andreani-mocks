using System.ComponentModel.DataAnnotations;

namespace Pedidos.Models;

public class Pedido
{
    [Required]
    public string almacenCliente { get; set; }
    public List<ArchivoRemito> archivoRemito { get; set; }
    public string cambioLoteDirigido { get; set; }
    public string cot { get; set; }
    public List<DatosAdicionales> datosAdicionales { get; set; }
    [Required]
    public Destinatario destinatario { get; set; }
    [Required]
    public Distribuidor distribuidor { get; set; }
    public string estatusOtDeTraza { get; set; }
    public string facturaLegal { get; set; }
    public string fechaDeExpedicionSolicitada { get; set; }
    public string fechaDeFacturacion { get; set; }
    public string fechaEntrega { get; set; }
    [Required]
    public string fechaPedido { get; set; }
    public string franjaHoraria { get; set; }
    [Required]
    public List<Linea> lineas { get; set; }
    public List<LinkImpresionRemito> linkImpresionRemito { get; set; }
    public string marketPlace { get; set; }
    public string notas { get; set; }
    [Required]
    public string numeroOrdenExterna { get; set; }
    public string ordenCompra { get; set; }
    public string precioValorFc { get; set; }
    [Required]
    public string propietario { get; set; }
    public string remito { get; set; }
    public string tieneGestionCobranza { get; set; }
    public string valorDeclarado { get; set; }
}
