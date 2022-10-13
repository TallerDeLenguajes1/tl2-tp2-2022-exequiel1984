using NLog;

namespace InstitutoEducacionFisica
{
    public class CrearAlumno
    {
        private static readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

        public static void CargarAlumno()
        {
            try
            {
                Alumno NuevoAlumno = new Alumno();

                Console.WriteLine("\nDatos del alumno");
                Console.WriteLine("Ingrese el apellido:");
                NuevoAlumno.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre:");
                NuevoAlumno.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el DNI:");
                NuevoAlumno.Dni = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese curso:");
                Console.WriteLine("1: Atletismo, 2: Voley, 3: Futbol");
                NuevoAlumno.Curso = Convert.ToInt32(Console.ReadLine());

                string archivo = HelperDeArchivos.SeleccionArchivoCSVPorCurso(NuevoAlumno.Curso);
                NuevoAlumno.Id = HelperDeArchivos.IdentificarSiguienteIDEnCSV(archivo);

                HelperDeArchivos.EscribirContenidoCSV(NuevoAlumno);
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
            catch (IOException ex)
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
            catch (OutOfMemoryException ex)
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
            catch (ArgumentOutOfRangeException ex)
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
            catch (ArgumentNullException ex)
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