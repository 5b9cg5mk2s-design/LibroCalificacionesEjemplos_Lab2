using System;

public class LibroCalificacionesParametro
{
	private string nombreCurso;
	public LibroCalificacionesParametro(string nombre)
	{
		nombreCurso = nombre;
	}

	public string NombreCurso
	{
		get { return nombreCurso; }
		set { nombreCurso = value; }
	}
	public void MostrarMensaje(string nombreCurso)
	{
		Console.WriteLine("¡Bienvenido al Libro de Calificaciones para\n{0}!",nombreCurso);
	}
}
