using NLog;

namespace InstitutoEducacionFisica
{
    static class HelperDeArchivos
    {
        public static void EscribirContenidoCSV(Alumno AlumnoACargar, Logger log)
        {
            string datos = Convert.ToString(AlumnoACargar.Id) + "," + AlumnoACargar.Apellido + "," + AlumnoACargar.Nombre + "," + Convert.ToString(AlumnoACargar.Dni);

            string archivo = "";
            switch (AlumnoACargar.Curso)
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

            var escribir = new StreamWriter(File.Open(archivo, FileMode.Append));
            escribir.WriteLine(datos);
            escribir.Close();

            log.Info($"{DateTime.Now}: Se ha agregado un nuevo alumno al archivo {Path.GetFileName(archivo)}");
        }
    }
}