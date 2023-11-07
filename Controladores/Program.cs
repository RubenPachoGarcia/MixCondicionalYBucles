using MixCondicionalYBucles.Servicios;

namespace CalculadoraLogica
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicacion
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo de entrada a la aplicacion
        /// Contiene el flujo de la aplicacion
        /// 061123 - rpg
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {                        
            //Llamada al metodo. Imprime el mensaje por consola. Se realiza a mi una copia de MenuImplementacion
            MenuInterfaz mi = new MenuImplementacion();
            //Opciones del usuario
            int mes;            
            int anio;
            //Se asignan a las variables mes y anio los valores de la copia de menuInterfaz
            mes = mi.pedirMes();
            Console.WriteLine(mes);
            anio = mi.pedirAnio();
            
            //Switch que va a mostrar un mensaje por pantalla determinado segun el mes y año que introduzca el usuario
            switch (mes)
                {
                    case 1:
                        Console.WriteLine("[INFO] - El mes introducido es Enero, que tiene 31 dias");
                        break;

                    case 2:
                    if (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0)) 
                        {
                            Console.WriteLine("[INFO] - El mes introducido es Febrero, que tiene 29 dias");
                        }
                        else
                        {
                            Console.WriteLine("[INFO] - El mes introducido es Febrero, que tiene 28 dias");
                        }
                        break;

                    case 3:
                        Console.WriteLine("[INFO] - El mes introducido es Marzo, que tiene 31 dias");                                                
                        break;

                    case 4:
                        Console.WriteLine("[INFO] - El mes introducido es Abril, que tiene 30 dias");
                        break;

                    case 5:
                        Console.WriteLine("[INFO] - El mes introducido es Mayo, que tiene 31 dias");
                        break;

                    case 6:
                        Console.WriteLine("[INFO] - El mes introducido es Junio, que tiene 30 dias");
                        break;

                    case 7:
                        Console.WriteLine("[INFO] - El mes introducido es Julio, que tiene 31 dias");
                        break;

                    case 8:
                        Console.WriteLine("[INFO] - El mes introducido es Agosto, que tiene 31 dias");
                        break;

                    case 9:
                        Console.WriteLine("[INFO] - El mes introducido es Septiembre, que tiene 30 dias");
                        break;

                    case 10:
                        Console.WriteLine("[INFO] - El mes introducido es Octubre, que tiene 31 dias");
                        break;

                    case 11:
                        Console.WriteLine("[INFO] - El mes introducido es Noviembre, que tiene 30 dias");
                        break;

                    case 12:
                        Console.WriteLine("[INFO] - El mes introducido es Diciembre, que tiene 31 dias");
                        break;

                    default:
                        Console.WriteLine("[INFO] - La opcion introducida no existe");
                        break;
                }

            //Opcion del usuario
            string respuestaS;
            respuestaS = mi.cerrarMenu();
            string respuesta;

            //If que segun el char que introduzca el usuario cerrara o no la aplicacion 
            if (respuesta==respuestaS)
            {
                Console.ReadLine().ToLower();
            }
            else
            {
                break;
            }
            

        }
    }
}
            
    

