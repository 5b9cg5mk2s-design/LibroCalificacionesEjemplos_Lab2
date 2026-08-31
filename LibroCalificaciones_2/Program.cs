using System;

namespace AplicacionLibroCalificaciones_2
{
    public class LibroPruebaCalificaciones
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            MiLibroCalificaciones MyLibro = new MiLibroCalificaciones();
            //Pide el nombre del curso y lo recibe como entrada
            Console.WriteLine("Por favor ingrese el nombre del curso: ");

            string nombreDelCurso = Console.ReadLine(); //Lee una línea de texto
            Console.WriteLine(); //Imprime una línea en blanco porque no se le ha pasado ningún parámetro, nos funciona como un salto de línea
            /*Llama al método MostrarMensaje de MiLibroCalificaciones
             y pasa el nombre del curso como argumento
            */
            MyLibro.MostrarMensaje(nombreDelCurso);
        }
    }
}