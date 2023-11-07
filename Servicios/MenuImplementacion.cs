using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MixCondicionalYBucles.Servicios
{
    /// <summary>
    /// Implementacion de las acciones del menu
    /// 061123 - rpg
    /// </summary>
    internal class MenuImplementacion:MenuInterfaz
    {
        //Desarrollamos el flujo del metodo que va a pedir el mes
        public int pedirMes()
        {
            int mes;
            
            Console.WriteLine("Seleccione una opcion: ");
            Console.WriteLine("##############################");
            Console.WriteLine("1. Enero");
            Console.WriteLine("2. Febrero");
            Console.WriteLine("3. Marzo");
            Console.WriteLine("4. Abril");
            Console.WriteLine("5. Mayo");
            Console.WriteLine("6. Junio");
            Console.WriteLine("7. Julio");
            Console.WriteLine("8. Agosto");
            Console.WriteLine("9. Septiembre");
            Console.WriteLine("10. Octubre");
            Console.WriteLine("11. Noviembre");
            Console.WriteLine("12. Diciembre");
            Console.WriteLine("##############################");

            mes = Console.ReadKey(true).KeyChar - '0';
            return mes;
        }

        //Desarrollamos el flujo del metodo que va a pedir el anio
        public int pedirAnio()
        {
            int anio;
            Console.WriteLine("Introduzca un año cualquiera: ");
            anio = Convert.ToInt32(Console.ReadLine());
            return anio;
        }

        //Desarrollamos el flujo del metodo que va a a preguntarnos si queremos seguir usando la aplicacion o no
        public string cerrarMenu() {

            string respuestaS = "si";
            string respuesta;
            respuesta=Convert.ToString(Console.ReadLine());
            Console.WriteLine("¿Desea continuar utilizando nuestra aplicacion? s/n");                                   
        }
    }
}
