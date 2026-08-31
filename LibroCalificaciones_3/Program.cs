namespace AplicacionLibroCalificaciones_2
{
    public class PruebaLibroCalificacionesParametro
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            LibroCalificacionesParametro MyLibro = new LibroCalificacionesParametro("CS101 Programación en C#");
            LibroCalificacionesParametro MyLibro2 = new LibroCalificacionesParametro("CS102 Estructuras de datos");
            Console.WriteLine("El nombre del curso es: {0}", MyLibro.NombreCurso);
            Console.WriteLine("El nombre del curso es: {0}", MyLibro2.NombreCurso);

            //Pide el nombre del curso y lo recibe como entrada
            Console.WriteLine("Por favor ingrese el nombre del curso: ");
            string elNombreCurso = Console.ReadLine(); //Lee una línea de texto
            MyLibro.NombreCurso = elNombreCurso; //Establece el nombre del curso usando una propiedad
            Console.WriteLine("El nombre del curso es: {0}", MyLibro.NombreCurso);
        }
    }
}