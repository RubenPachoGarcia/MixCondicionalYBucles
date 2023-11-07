using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixCondicionalYBucles.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra y recoge la seleccion del usuario
        /// 061123 - rpg
        /// </summary>
        /// <returns>entero con la opcion seleccionada</returns>
        
        //Creamos el metodo que va a pedir el mes
        public int pedirMes();

        //Creamos el metodo que va a pedir el anio
        public int pedirAnio();
        
        //Creamos el metodo que va a preguntarnos si se quiere seguir usando la aplicacion o no
        public string cerrarMenu();
    }
}
