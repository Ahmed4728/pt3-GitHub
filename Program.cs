using System;
using Models;  // Importa la classe Vehicle des de Models

class Program
{
    static void Main(string[] args)
    {
        // Crear un objecte Vehicle
        Vehicle vehicle1 = new Vehicle("c3", "Citroen", 2019, 160.0);

        // Mostrar la informació del vehicle
        vehicle1.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Vehicle vehicle2 = new Vehicle("c2", "Citroen", 2020, 135.0);
        
        // Mostrar la informació del segon vehicle
        vehicle2.MostrarInformacio();
    }
}
