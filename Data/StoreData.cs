using Store_Tec_API_GET.Models;
namespace Store_Tec_API_GET.Data;
public class StoreData {
 public List<Categoria> Categorias {get;}=[new(1,"Celulares","Smartphones y teléfonos móviles"),new(2,"Laptops","Computadoras portátiles"),new(3,"Accesorios","Accesorios tecnológicos")];
 public List<Marca> Marcas {get;}=[new(1,"Samsung"),new(2,"Lenovo"),new(3,"Logitech")];
 public List<Producto> Productos {get;}=[new(1,"Samsung Galaxy A56","Smartphone de gama media",1499.90m,15,1,1),new(2,"Lenovo IdeaPad 3","Laptop para estudio y trabajo",1899.00m,10,2,2),new(3,"Logitech M185","Mouse inalámbrico",59.90m,30,3,3),new(4,"Samsung Galaxy Buds FE","Audífonos inalámbricos",249.90m,20,3,1)];
 public List<Promocion> Promociones {get;}=[new(1,"Oferta Smartphone","Descuento especial",10,1,true),new(2,"Oferta Laptop","Precio promocional",8,2,true)];
}
