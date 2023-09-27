using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenúPersonal.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz menú.
    /// 270923 - chi
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz //conecta los servicios
    {
        //La clase va a contener tanto el mensaje de la app como el menú
        public void mensajeApp()
        {
            string mensaje = "Bienvenido a Futbol Total";
            Console.WriteLine(mensaje);
        }

        public int menuDeEleccion()
        {
            int opcionElegida;
            Console.WriteLine("-----------------------");
            Console.WriteLine("Cerrar APP");
            Console.WriteLine("Equipos");
            Console.WriteLine("Plantillas");
            Console.WriteLine("Clasificación");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Seleccione una opción: ");

            opcionElegida = Console.ReadKey(true).KeyChar - ("0"); //Lee solo un carácter

            return opcionElegida;
        }
    }
}
