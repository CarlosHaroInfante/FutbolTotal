using MenuPersonal.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPersonal.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz menú.
    /// 270923 - chi
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz //conecta los servicios
    {
        //La clase va a contener tanto el mensaje de la app como el menú
        public void MensajeApp()
        {
            string mensaje = "Bienvenido a Futbol Total";
            Console.WriteLine(mensaje);
        }

  

        public int MenuDeEleccion()
        {
            int opcionElegida;
            Console.WriteLine("-----------------------");
            Console.WriteLine("0. Cerrar APP");
            Console.WriteLine("1. Equipos");
            Console.WriteLine("2. Plantillas");
            Console.WriteLine("3. Clasificación");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Seleccione una opción: ");

            opcionElegida = Console.ReadKey(true).KeyChar - ('0'); //Lee solo un carácter

            return opcionElegida;
        }

    }
}
