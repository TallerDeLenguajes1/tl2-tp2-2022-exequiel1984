using NLog;

namespace InstitutoEducacionFisica
{
    public class Program
    {
        private static readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            try
            {
                CrearAlumno.CargarAlumno();  
            
                Console.WriteLine("Seleccione el listado a borrar (1 Atletismo / 2 Voley / 3 Futbol):");
                int ListadoABorrar = Convert.ToInt32(Console.ReadLine());

                HelperDeArchivos.BorrarListadoCSV(ListadoABorrar);

                Console.WriteLine("fin");
            }
            catch (FormatException ex)
            {
                var mensaje = "Error message: " + ex.Message;

                if (ex.InnerException != null)
                {
                    mensaje = mensaje + " Inner exception: " + ex.InnerException.Message;
                }

                mensaje = mensaje + " Stack trace: " + ex.StackTrace;

                Log.Error(mensaje);
                throw;
            }
            catch (OverflowException ex)
            {
                var mensaje = "Error message: " + ex.Message;

                if (ex.InnerException != null)
                {
                    mensaje = mensaje + " Inner exception: " + ex.InnerException.Message;
                }

                mensaje = mensaje + " Stack trace: " + ex.StackTrace;

                Log.Error(mensaje);
                throw;
            }
            
        }
    }
}