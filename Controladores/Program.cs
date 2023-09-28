using MenuPersonal.Servicios;
using System;

namespace MenuPersonal.Controladores
{
    ///<summary>
    ///Clase principal de la aplicacion
    ///270923 - chi
    /// </summary>  

    class Program
    {
        ///<summary>
        ///Método de entrada a la aplicaión
        ///270923 - chi
        ///</summary>

        static void Main(string[] args)
        {

            MenuInterfaz menuInterfaz = new MenuImplementacion();
            menuInterfaz.MensajeApp();


            //Variable de control de entrada/salida del bucle
            bool cerrarMenu = false;

            //Contiene la elección del usuario

            int opcionElegida;

            //Desde la primera iteración (vuelta) debe cumplirse la condición.

            while (!cerrarMenu)
            {
                opcionElegida = menuInterfaz.MenuDeEleccion();
                Console.WriteLine(opcionElegida);


                switch (opcionElegida)
                {
                    case 0:
                        Console.WriteLine("[INFO] - 0. Esta opción cerrará el menú");
                        cerrarMenu = true;
                        break; //sale del switch y pasa a la siguiente parte del código

                    case 1:
                        Console.WriteLine("[INFO] - 1. Has elegido Equipos de LaLiga");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - 2. Has elegido Plantillas de LaLiga");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - 3. Has elegido Clasificación de LaLiga");
                        break;
                    default:
                        Console.WriteLine("[INFO] La opción seleccionada no coincide con ninguna");
                        break;
                }
            }

        }
    }
}
    


