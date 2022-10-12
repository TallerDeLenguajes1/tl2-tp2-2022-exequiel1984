using NLog;

namespace InstitutoEducacionFisica
{
    

    static class HelperDeArchivos
    {
        public static string SeleccionArchivoCSVPorCurso(int Curso)
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

        public static void EscribirContenidoCSV(Alumno AlumnoACargar, Logger log)
        {
            string datos = Convert.ToString(AlumnoACargar.Id) + "," + AlumnoACargar.Apellido + "," + AlumnoACargar.Nombre + "," + Convert.ToString(AlumnoACargar.Dni);
            
            string archivo = SeleccionArchivoCSVPorCurso(AlumnoACargar.Curso);

            var escribir = new StreamWriter(File.Open(archivo, FileMode.Append));
            escribir.WriteLine(datos);
            escribir.Close();

            log.Info($"{DateTime.Now}: Se ha agregado un nuevo alumno al archivo {Path.GetFileName(archivo)}");
        }

        public static int IdentificarSiguienteIDEnCSV(string archivo)
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
    }

    
}