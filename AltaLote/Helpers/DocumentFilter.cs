using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace AltaLote.Helpers;

public class BasePathDocumentFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        swaggerDoc.Servers = new List<OpenApiServer>() { new() { Url = "http://localhost:5004" } };
    }
}