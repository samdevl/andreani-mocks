using System.ComponentModel.DataAnnotations;

namespace Pedidos.Models;

public class Destinatario
{
    public string contacto { get; set; }
    [Required]
    public Direccion direccion { get; set; }
    public string email { get; set; }
    [Required]
    public string idDestinatario { get; set; }
    public string idInternoCliente { get; set; }
    public string nombreCompleto { get; set; }
    public string numeroDeDocumento { get; set; }
    public string telefono { get; set; }
    public string tipoDeDocumento { get; set; }
}