using System.ComponentModel.DataAnnotations;

namespace Pedidos.Models;

public class Lote
{
    [Required]
    public string estado { get; set; }
    public string fechaDeVencimiento { get; set; }
    public string loteDeFabricante { get; set; }
    public string loteSecundario { get; set; }
    public List<DatosAdicionales> otrosDatos { get; set; }
}