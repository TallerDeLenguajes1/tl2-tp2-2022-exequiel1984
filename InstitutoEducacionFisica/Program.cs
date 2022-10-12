using NLog;

namespace InstitutoEducacionFisica
{
    internal class Program
    {
        private static readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            CargarAlumno();   
        }

        private static void CargarAlumno()
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

                HelperDeArchivos.EscribirContenidoCSV(NuevoAlumno, Log);
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

                Console.WriteLine("El formato de un argumento es inválido");
                Console.WriteLine($"Nombre de la fuente del error: {ex.Source}");
                Console.WriteLine($"Nombre que lanza la excepcion: {ex.TargetSite}");
                Console.WriteLine($"Diccionario con info adicional: {ex.Data}");
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

                Console.WriteLine("Una operación aritmética, de casteo o conversión ha sufrido una sobrecarga");
                Console.WriteLine($"Nombre de la fuente del error: {ex.Source}");
                Console.WriteLine($"Nombre que lanza la excepcion: {ex.TargetSite}");
                Console.WriteLine($"Diccionario con info adicional: {ex.Data}");
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

                Console.WriteLine("Ha ocurrido un error de Entrada/Salida");
                Console.WriteLine($"Nombre de la fuente del error: {ex.Source}");
                Console.WriteLine($"Nombre que lanza la excepcion: {ex.TargetSite}");
                Console.WriteLine($"Diccionario con info adicional: {ex.Data}");
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

                Console.WriteLine("No hay suficiente espacio de memoria para continuar la ejecución del programa");
                Console.WriteLine($"Nombre de la fuente del error: {ex.Source}");
                Console.WriteLine($"Nombre que lanza la excepcion: {ex.TargetSite}");
                Console.WriteLine($"Diccionario con info adicional: {ex.Data}");
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

                Console.WriteLine("El valor de un argumento sobrepasa el rango límite definido");
                Console.WriteLine($"Nombre de la fuente del error: {ex.Source}");
                Console.WriteLine($"Nombre que lanza la excepcion: {ex.TargetSite}");
                Console.WriteLine($"Diccionario con info adicional: {ex.Data}");
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

                Console.WriteLine("Se ha pasado un valor nulo a un método que no acepta valores nulos");
                Console.WriteLine($"Nombre de la fuente del error: {ex.Source}");
                Console.WriteLine($"Nombre que lanza la excepcion: {ex.TargetSite}");
                Console.WriteLine($"Diccionario con info adicional: {ex.Data}");
                throw;
            }  
                
        }
    }
}