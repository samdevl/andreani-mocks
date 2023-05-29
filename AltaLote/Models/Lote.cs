using System.ComponentModel.DataAnnotations;

namespace AltaLote.Models;

public class Lote
{
    [Required]
    public string almacen { get; set; }
    [Required]
    public DetalleDeLote detalleDeLote { get; set; }
    [Required]
    public string instancia { get; set; }
}