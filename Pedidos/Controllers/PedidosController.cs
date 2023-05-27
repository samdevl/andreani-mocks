using Microsoft.AspNetCore.Mvc;
using Pedidos.Models;

namespace Pedidos.Controllers;

[ApiController]
[Route("almacenes/pedidos")]
public class PedidosController : ControllerBase
{
    /// <summary>
    /// Generar una solicitud de alta de pedido
    /// </summary>
    /// <param name="pedido">Pedido</param>
    [HttpPost]
    public IActionResult Post(PedidoRequest pedido)
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
    /// Consulta una solicitud de alta pedido
    /// </summary>
    /// <param name="idTransaccion">Id del pedido</param>

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        if (id > 10000000 && id < 99999999)
        {
            return Ok();
        };

        return NotFound("No se ha encontrado el lote");
    }
}