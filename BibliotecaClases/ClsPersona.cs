namespace BibliotecaClases
{
    
    public class ClsPersona
    {
        public String Nombre {  get; set; }
        public String Apellidos { get; set; }

        int Edad {  get; set; }

        public ClsPersona(string nombre, string apellidos, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

    }
    
}
