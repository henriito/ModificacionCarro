using Clase7.Clases;

Carro HenCarrito = new Carro("Hyundai", " Blanco"," 350KPH");
Console.WriteLine($"Marca: {HenCarrito.Marca}, Color: {HenCarrito.Color}, Velocidad Máxima: {HenCarrito.VelocidadMax}");

HenCarrito.EncenderMotor();
for (int i = 0; i < 10; i++)
{
    HenCarrito.acelerar(i);
}
HenCarrito.desacelerar(15);
HenCarrito.frenar();
HenCarrito.ApagarMotor();

