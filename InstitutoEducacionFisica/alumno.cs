namespace InstitutoEducacionFisica
{
    public class Alumno
    {
        private int id;
        private string nombre;
        private string apellido;
        private int dni;
        private int curso;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Curso { get => curso; set => curso = value; }

        public Alumno()
        {

        }

        public Alumno(int idAlumno, string nombreAlumno, string apellidoAlumno, int dniAlumno, int cursoAlumno)
        {
            this.Id = idAlumno;
            this.Nombre = nombreAlumno;
            this.Apellido = apellidoAlumno;
            this.Dni = dniAlumno;
            this.Curso = cursoAlumno;
        }
    }
}