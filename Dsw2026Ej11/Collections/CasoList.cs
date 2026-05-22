namespace Dsw2026Ej11.Collections;

using Domain;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> Alumnos;
    public CasoList() 
        => Alumnos = new List<Alumno>();

    public void AgregarAlumnos(Alumno alumno) 
        => Alumnos.Add(alumno);

    public List<Alumno> RetornarLista() 
        => Alumnos;
    
    public Alumno? RetornarAlumno(string nombre) 
        => Alumnos.Find(n => n.Nombre == nombre);
    
    public void EliminarAlumno(Alumno alumno)
        => Alumnos.Remove(alumno);
    public void EliminarAlumno(int posicion)
        => Alumnos.RemoveAt(posicion);
}
