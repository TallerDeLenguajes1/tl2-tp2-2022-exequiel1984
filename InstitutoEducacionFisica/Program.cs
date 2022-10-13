using NLog;

namespace InstitutoEducacionFisica
{
    private static readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

    public class Program
    {

        static void Main(string[] args)
        {
            CrearAlumno.CargarAlumno(Log);  
            
            Console.WriteLine("Seleccione el listado a borrar (1 Atletismo / 2 Voley / 3 Futbol):");
            int ListadoABorrar = Convert.ToInt32(Console.ReadLine());

            HelperDeArchivos.BorrarListadoCSV(ListadoABorrar, Log);

            Console.WriteLine("fin");
        }
    }
}