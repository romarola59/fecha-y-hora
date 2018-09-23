using System;

namespace fecha_y_hora
{
    public class Program
    {
        public static void Main()
        {
            DateTime fecha = DateTime.Now;   // creo una variable para una nueva fecha
            Console.WriteLine("Hoy es {0} del mes {1} de {2}",fecha.Day,fecha.Month,fecha.Year);
            DateTime manyana = fecha.AddDays(1); // comando para aunmentar un dia 
            Console.WriteLine("Mañana sera {0}", manyana.Day);
            Console.ReadKey();
        }
        
    }
}
