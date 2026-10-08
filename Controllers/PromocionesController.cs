using Microsoft.AspNetCore.Mvc; using Store_Tec_API_GET.Data;
namespace Store_Tec_API_GET.Controllers;
[ApiController][Route("api/[controller]")] public class PromocionesController(StoreData d):ControllerBase{[HttpGet]public IActionResult Get(bool? activas){var q=d.Promociones.AsEnumerable();if(activas.HasValue)q=q.Where(x=>x.Activa==activas);return Ok(q);}[HttpGet("{id:int}")]public IActionResult Get(int id){var x=d.Promociones.FirstOrDefault(a=>a.Id==id);return x is null?NotFound(new{mensaje="Promoción no encontrada"}):Ok(x);}}
