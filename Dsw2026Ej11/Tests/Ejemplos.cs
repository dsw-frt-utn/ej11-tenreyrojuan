using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList cList = new CasoList();
        Alumno a1 = new Alumno(1, "juan", 7.78);
        Alumno a2 = new Alumno(2, "lucas", 7.5);
        Alumno a3 = new Alumno(3, "sebastian", 6.4);
        cList.AgregarAlumnos(a1);
        cList.AgregarAlumnos(a2);
        cList.AgregarAlumnos(a3);

        foreach(var a in cList.RetornarLista())          
            Console.WriteLine("Alumnos" + a.ToString());
        

        Console.WriteLine();
        Console.WriteLine("Alumno: " + cList.RetornarAlumno("juan"));

        Console.WriteLine();
        if (cList.RetornarAlumno("joaquin") == null)
            Console.WriteLine("No Existe");

        cList.EliminarAlumno(a3);
        Console.WriteLine();
        foreach (var a in cList.RetornarLista())
        {
            Console.WriteLine("Alumnos" + a.ToString());
        }

        Console.WriteLine();
        cList.EliminarAlumno(0);
        foreach(var a in cList.RetornarLista())
        {
            Console.WriteLine("Alumnos" + a.ToString());
        }

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        Alumno a1 = new Alumno(60850, "Juan", 7.78);
        Alumno a2 = new Alumno(62286, "Lucas", 7.50);
        Alumno a3 = new Alumno(62271, "Sebastian", 6.50);

        CasoDictionary cDict = new CasoDictionary();
        cDict.AgregarAlumno(a1);
        cDict.AgregarAlumno(a2);
        cDict.AgregarAlumno(a3);
        Console.WriteLine("Listado de Alumnos: ");
        foreach (var (id,alumnos) in cDict.GetDiccionario())
            Console.WriteLine(alumnos.ToString());

        Console.WriteLine("\nAlumno por clave: " + cDict.BuscarAlumno(60850)!.ToString());

        if (cDict.BuscarAlumno(62270) == null)
            Console.WriteLine("\nNo Existe");

        cDict.EliminarAlumno(62271);
        Console.WriteLine("\nListado de Alumnos: ");
        foreach (var (id,alumnos) in cDict.GetDiccionario())
            Console.WriteLine(alumnos.ToString());

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq cLinq = new CasoLinq();
        Console.WriteLine("Primero: " + cLinq.GetPrimero()?.ToString());
        Console.WriteLine("\nUltimo: " + cLinq.GetUltimo()?.ToString());
        Console.WriteLine("\nTotal Precios: " + cLinq.GetTotalPrecios().ToString());
        Console.WriteLine("\nPromedio Precios: " + cLinq.GetPromedioPrecios().ToString());
        Console.WriteLine("\nLista por id: ");
        foreach (var libro in cLinq.GetListById()!)
            Console.WriteLine(libro.ToString());
        Console.WriteLine("\nLista de Libros: ");
        foreach (var libro in cLinq.GetLibros()!)
            Console.WriteLine(libro.ToString());
        Console.WriteLine("\nMayor Precio: " + cLinq.GetMayorPrecio()?.ToString());
        Console.WriteLine("\nMenor Precio: " + cLinq.GetMenorPrecio()?.ToString());
        Console.WriteLine("\nMayor que el Promedio: ");
        foreach (var libro in cLinq.GetMayorPromedio()!) 
            Console.WriteLine(libro.ToString());
        Console.WriteLine("\nOrdenados de Forma descendente: ");
        foreach (var libro in cLinq.GetTitulosDescendientes()!)
            Console.WriteLine(libro.ToString());
    }
}
