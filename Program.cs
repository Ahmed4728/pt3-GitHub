using System;
using Models;  // Importa la classe Vehicle des de Models

class Program
{
    static void Main(string[] args)
    {
        // Crear un objecte Vehicle
        Cotxe cotxe1 = new Cotxe("c3", "Citroen", 2019, 160.0, 5);

        // Mostrar la informació del vehicle
        cotxe1.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Cotxe cotxe2 = new Cotxe("c2", "Citroen", 2020, 135.0, 5);
        
        // Mostrar la informació del segon vehicle
        cotxe2.MostrarInformacio();
    }
}
