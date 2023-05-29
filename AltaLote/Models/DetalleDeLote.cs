using System.ComponentModel.DataAnnotations;

namespace AltaLote.Models;

public class DetalleDeLote
{ 
        [Required]
        public string articulo { get; set; }
        public string consumoAntesDe { get; set; }
        public string entregaAntesDe { get; set; }
        public string estadoDeUbicacionLote { get; set; }
        [Required]
        public string estadoLote { get; set; }
        public string fechaFabricacion { get; set; }
        public string fechaVencimiento { get; set; }
        [Required]
        public string loteCaja { get; set; }
        [Required]
        public string loteSecundario { get; set; }
        public string paquete { get; set; }
        [Required]
        public string propietario { get; set; }
        [Required]
        public int trazable { get; set; }
        public int vidaUtil { get; set; }
        public string zonaConsumo { get; set; }
}