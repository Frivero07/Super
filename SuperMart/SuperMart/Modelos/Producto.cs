
namespace SuperMart.Modelos
{
    public class Producto
    {
        private string _nombre = null;
        private double _precio;
        private Articulo _articulo;


        public Producto(string nombre, double precio, Articulo articulo)
        {
            _nombre = nombre;
            _precio = precio;
            _articulo = articulo;
           
            
        }

        public string nombre => _nombre;

        public double precio => _precio;

        public Articulo articulo => _articulo;
    public void MostrarDetalles()
    {
     Console.WriteLine($"Nombre:{nombre}\n" +
      $"El precio es:{precio}\n" +
      $"El articulo es {articulo}");
    }
    }
}
    

