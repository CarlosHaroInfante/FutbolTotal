using MenúPersonal.Servicios;

namespace MenúPersonal.Controladores
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

        private static void Main(string[] args);{

        MenuInterfaz menuInterfaz = new MenuImplementacion();
        MenuInterfaz.mensajeApp();
    }
}

