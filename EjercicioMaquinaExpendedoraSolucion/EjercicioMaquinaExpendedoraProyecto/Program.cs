// See https://aka.ms/new-console-template for more information
using EjercicioMaquinaExpendedoraProyecto;

Console.WriteLine("Hello, World!");


Producto producto = new Producto();
producto.Nombre = "Coca-Cola";
producto.Precio = 1.5f;
producto.cantidadDisponible = 10;

Monedero m = new Monedero(2.5f, "Pepito");

VendingMachine maquina = new VendingMachine(new Producto[] { producto });
maquina.encender();

Console.WriteLine("Bienvenido a la maquina de vending. Por favor, ingrese el nombre del producto que desea comprar: ");
string productoElegido = Console.ReadLine();
if(maquina.comprarProducto(productoElegido, m) != -1)
{
    Console.WriteLine("Gracias por su compra.");
}
else
{
    Console.WriteLine("Producto no disponible o saldo insuficiente.");
}