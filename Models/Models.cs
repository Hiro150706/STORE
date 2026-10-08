namespace Store_Tec_API_GET.Models;
public record Categoria(int Id,string Nombre,string Descripcion);
public record Marca(int Id,string Nombre);
public record Producto(int Id,string Nombre,string Descripcion,decimal Precio,int Stock,int CategoriaId,int MarcaId);
public record Promocion(int Id,string Nombre,string Descripcion,decimal Descuento,int ProductoId,bool Activa);
