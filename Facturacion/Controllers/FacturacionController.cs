using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Facturacion.Models;

namespace Facturacion.Controllers;

[ApiController]
[Route("facturacion")]
public class FacturacionController : ControllerBase
{
     /// <summary>
    /// Datos de facturación
    /// </summary>
     /// <param name="facturacion">Servicio generacion del evento de Datos Facturacion solicitada para el consumo de SCE</param>
     /// <returns>ID de transacción generado</returns>
     
     [HttpPost]
    public IActionResult Post([FromBody] FacturacionRequest facturacion)
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(10000000, 99999999);
        
        var respuesta = new
        { 
            idTransaccion = numeroAleatorio
        };
        
        return Ok(respuesta);
    }
     /// <summary>
     /// Transacción de Datos de Facturación
     /// </summary>
     /// <param name="facturacion">Servicio de consulta del estado de Datos facturacion Solicitada</param>
     [ProducesResponseType(typeof(FacturacionResponse), StatusCodes.Status200OK)]
    
     [HttpGet("{id}")]
     public IActionResult Get(int id)
     {
         if (id > 10000000 && id < 99999999)
         {
             return Ok(new FacturacionResponse
             {
                 Estado = "PENDIENTE",
                 FechaCreacion = DateTime.Now,
                 FechaModificacion = DateTime.Now,
                 Razon = "",
                 Request = new Request
                 {
                     Almacen = "string",
                     Instancia = "string",
                     ContratoDistribucion = "string",
                     Pedido = new Pedido
                     {
                         ArchivoImpresionRemito = "string",
                         Cot = "string",
                         DatosAdicionales = new List<DatosAdicionales>
                         {
                             new DatosAdicionales
                             {
                                 Contenido = "string",
                                 Meta = "string"
                             }
                         },
                         FacturaLegal = "string",
                         FechaDeFacturacion = "string",
                         FechaEntrega =  "string",
                         LinkImpresionRemito =  "string",
                         NumeroOrdenExterna =  "string",
                         PrecioValorFc =  "string",
                         Propietario =  "string",
                         Remito =  "string",
                         TieneGestionCobranza =  "string",
                         ValorDeclarado =  "string",
                     }
                 },
                 Response = new Response
                 {
                     IdTransaccion = id
                 }
             });
         }

         return NotFound("No se ha encontrado el lote");
     }

     

}