using System;
using Models;  // Importa la classe Vehicle des de Models

class Program
{
    static void Main(string[] args)
    {
        // Crear un objecte Vehicle
        Vehicle vehicle1 = new Vehicle("GT-R", "Nissan", 2019, 270.0);

        // Mostrar la informació del vehicle
        vehicle1.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Vehicle vehicle2 = new Vehicle("Almera", "Nissan", 2006, 170.0);
        
        // Mostrar la informació del segon vehicle
        vehicle2.MostrarInformacio();
    }
}
