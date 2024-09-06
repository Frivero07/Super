

namespace SuperMart.Modelos
{
    public class Inventario
    {
        public List<Producto> Productos { get; private set; } = new List<Producto>();

        public void AgregarProducto(Producto producto) => Productos.Add(producto);
        
    
        public void ConsultarInventario()
        {
            foreach (var producto in Productos)
            {
                Console.WriteLine($"Nombre:{producto.nombre}");
            }
        }
    }
}
