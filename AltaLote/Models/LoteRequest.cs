using System.ComponentModel.DataAnnotations;

namespace AltaLote.Models;

public class LoteRequest
{
    public string almacen { get; set; }
    public DetalleDeLote lote { get; set; }
    public string instancia { get; set; }
}