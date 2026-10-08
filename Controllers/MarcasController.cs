using Microsoft.AspNetCore.Mvc; using Store_Tec_API_GET.Data;
namespace Store_Tec_API_GET.Controllers;
[ApiController][Route("api/[controller]")] public class MarcasController(StoreData d):ControllerBase{[HttpGet]public IActionResult Get()=>Ok(d.Marcas);[HttpGet("{id:int}")]public IActionResult Get(int id){var x=d.Marcas.FirstOrDefault(a=>a.Id==id);return x is null?NotFound(new{mensaje="Marca no encontrada"}):Ok(x);}}
