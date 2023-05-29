using System;
using System.Collections.Generic;
using AltaLote.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltaLote.Controllers;

[ApiController]
[Route("/almacenes/lotes")]
public class LoteController : ControllerBase
{
    /// <summary>
    /// Envía una solicitud de alta de lote
    /// </summary>
    /// <param name="lote">Lote que se añadirá</param>
    /// <returns></returns>

    [HttpPost]
    public IActionResult Post([FromBody]Lote lote)
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
    /// Consulta de Solicitud de un alta de lote
    /// </summary>
    /// <param name="idTransaccion">Id del lote</param>
    [ProducesResponseType(typeof(LoteResponse), StatusCodes.Status200OK)]
    
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        if (id > 10000000 && id < 99999999)
        {
            return Ok(new LoteResponse
            {
                Estado = "PENDIENTE",
                FechaCreacion = DateTime.Now,
                FechaModificacion = DateTime.Now,
                Razon = "",
                Request = new LoteRequest
                {
                    almacen = "string",
                    instancia = "string",
                    lote = new DetalleDeLote
                    {
                        articulo = "string",
                        consumoAntesDe = "string",
                        entregaAntesDe = "string",
                        estadoDeUbicacionLote = "string",
                        estadoLote = "string",
                        fechaFabricacion = "string",
                        fechaVencimiento = "string",
                        loteCaja = "string",
                        loteSecundario = "string",
                        paquete = "string",
                        propietario = "string",
                        trazable = 0,
                        vidaUtil = 0,
                        zonaConsumo = "string"
                    }
                },
                Response = new { idTransaccion = id }
            });
        }

        return NotFound("No se ha encontrado el lote");
    }

    
}