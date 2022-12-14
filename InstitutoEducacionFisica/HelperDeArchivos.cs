using NLog;

namespace InstitutoEducacionFisica
{
    public class HelperDeArchivos
    {
        private static readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();
        
        public static string SeleccionArchivoCSVPorCurso(int Curso)
        {
            try
            {
                string archivo = "";
                switch (Curso)
                {
                    case 1:
                        archivo = "csv\\Atletismo.csv";
                        break;

                    case 2:
                        archivo = "csv\\Voley.csv";
                        break;

                    case 3:
                        archivo = "csv\\Futbol.csv";
                        break;

                    default:
                        break;
                    }

                return archivo;
            }
            catch (FileNotFoundException ex)
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
            catch (DirectoryNotFoundException ex)
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

        public static void EscribirContenidoCSV(Alumno AlumnoACargar)
        {
            try
            {
                string datos = Convert.ToString(AlumnoACargar.Id) + "," + AlumnoACargar.Apellido + "," + AlumnoACargar.Nombre + "," + Convert.ToString(AlumnoACargar.Dni);
            
                string archivo = SeleccionArchivoCSVPorCurso(AlumnoACargar.Curso);

                var escribir = new StreamWriter(File.Open(archivo, FileMode.Append));
                escribir.WriteLine(datos);
                escribir.Close();

                Log.Info($"{DateTime.Now}: Se ha agregado un nuevo alumno al archivo {Path.GetFileName(archivo)}");
            }
            catch (FileNotFoundException ex)
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
            catch (DirectoryNotFoundException ex)
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

        public static int IdentificarSiguienteIDEnCSV(string archivo)
        {
            try
            {
                var lectura = File.ReadAllText(archivo);
                if (lectura != "")
                {
                    var linea = (lectura.Split("\n"))[(lectura.Split("\n")).Length - 2];
                    return Convert.ToInt32((linea.Split(","))[0]) + 1;
                } else
                {
                    return 1;
                }
            }
            catch (FileNotFoundException ex)
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
            catch (DirectoryNotFoundException ex)
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
        
        public static void BorrarListadoCSV(int Curso)
        {
            try
            {
                string archivo = "";
                archivo = SeleccionArchivoCSVPorCurso(Curso);
                FileStream fileStream = File.Open(archivo, FileMode.Open);
                fileStream.SetLength(0);
                fileStream.Close();
        
                Log.Info($"{DateTime.Now}: Se borro el contenido del archivo {Path.GetFileName(archivo)}");
            }
            catch (FileNotFoundException ex)
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
            catch (DirectoryNotFoundException ex)
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