using NLog;

namespace InstitutoEducacionFisica
{
    public class Program
    {
        static void Main(string[] args)
        {
            private static readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

            CrearAlumno.CargarAlumno();  
            
            Console.WriteLine("Seleccione el listado a borrar (1 Atletismo / 2 Voley / 3 Futbol):");
            int ListadoABorrar = Convert.ToInt32(Console.ReadLine());

            HelperDeArchivos.BorrarListadoCSV(ListadoABorrar);

            Console.WriteLine("fin");
        }
    }
}