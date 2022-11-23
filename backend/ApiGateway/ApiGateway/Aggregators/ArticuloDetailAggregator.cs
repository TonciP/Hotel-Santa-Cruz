using Newtonsoft.Json;
using Ocelot.Middleware;
using Ocelot.Multiplexer;

namespace ApiGateway.Aggregators
{
    public class ArticuloDetailAggregator : IDefinedAggregator
    {
        public async Task<DownstreamResponse> Aggregate(List<HttpContext> response)
        {
            if(response.Any(x => x.Items.Errors().Count > 0))
            {
                return new DownstreamResponse(null, System.Net.HttpStatusCode.BadRequest,new List<Header>(), "Erros ocurred");
            }

            var articuloResponseJson = await response[0].Items.DownstreamResponse().Content.ReadAsStringAsync();
            var productoResponseJson = await response[1].Items.DownstreamResponse().Content.ReadAsStringAsync();

            var articulo = JsonConvert.DeserializeObject<ArticuloDto>(articuloResponseJson);
            var producto = JsonConvert.DeserializeObject<ProductoDto>(productoResponseJson);

            var contentBody = JsonConvert.SerializeObject(new
            {
                ProductoId = articulo.Id,
                Nombre = articulo.Nombre,
                CostoPromedio = articulo.CostoPromedio
            });

        }
    }
}
