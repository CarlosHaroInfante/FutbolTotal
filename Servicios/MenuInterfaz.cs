using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPersonal.Servicios
{
    /// <summary>
    /// Interfaz con la relación con la función del menú
    /// 270923 - chi
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el mensaje que aparece al iniciar la app
        /// 270923 - chi
        /// </summary>
        public void MensajeApp();

        ///<summary>
        /// Método que muestra el menú y la elección del usuario
        /// 270923 - chi
        /// </summary>

        public int MenuDeEleccion();
        
    }
}
