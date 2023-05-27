using System.ComponentModel.DataAnnotations;

namespace Pedidos.Models;

public class Linea
{
    public string admitePickingParcial { get; set; }
    [Required]
    public Articulo articulo { get; set; }
    [Required]
    public string contratoWarehouse { get; set; }
    public int diasVencimientoMinimo { get; set; }
    public string estatusOtDeAcondi { get; set; }
    [Required]
    public string numeroDeLinea { get; set; }
    public string tipoDeAcondicionamientoSecundario { get; set; }
    public List<int> tiposDeAcondicionamientoSecundario { get; set; }
}
