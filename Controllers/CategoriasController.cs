using Microsoft.AspNetCore.Mvc; using Store_Tec_API_GET.Data;
namespace Store_Tec_API_GET.Controllers;
[ApiController][Route("api/[controller]")] public class CategoriasController(StoreData d):ControllerBase{[HttpGet]public IActionResult Get()=>Ok(d.Categorias);[HttpGet("{id:int}")]public IActionResult Get(int id){var x=d.Categorias.FirstOrDefault(a=>a.Id==id);return x is null?NotFound(new{mensaje="Categoría no encontrada"}):Ok(x);}}
