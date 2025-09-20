namespace PatronComposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Demostración del Patrón Composite ---");
            Console.WriteLine("----------------------------------------");

            // Crear objetos 'Hoja' (Leaf) - Representan estudiantes individuales con sus promedios
            Estudiante juan = new Estudiante("Juan", 8.5);
            Estudiante ana = new Estudiante("Ana", 9.0);
            Estudiante luis = new Estudiante("Luis", 7.8);
            Estudiante maria = new Estudiante("Maria", 9.5);

            // Crear un objeto 'Compuesto' (Composite) - Representa un grupo de estudiantes
            GrupoEstudiantes grupoA = new GrupoEstudiantes("Grupo de Programación");
            grupoA.agregarParticipante(juan);
            grupoA.agregarParticipante(ana);

            // Crear otro objeto 'Compuesto'
            GrupoEstudiantes grupoB = new GrupoEstudiantes("Grupo de Base de Datos");
            grupoB.agregarParticipante(luis);
            grupoB.agregarParticipante(maria);

            // Agregar un grupo dentro de otro grupo, demostrando la naturaleza recursiva del patrón
            GrupoEstudiantes grupoCompleto = new GrupoEstudiantes("Curso Completo");
            grupoCompleto.agregarParticipante(grupoA);
            grupoCompleto.agregarParticipante(grupoB);

            // Usar la misma operación para mostrar los promedios de todos
            Console.WriteLine($"\nEl promedio del {grupoA.getNombre()} es: {grupoA.getPromedio():F2}");
            Console.WriteLine($"El promedio del {grupoB.getNombre()} es: {grupoB.getPromedio():F2}");
            Console.WriteLine($"El promedio del {grupoCompleto.getNombre()} es: {grupoCompleto.getPromedio():F2}");

            Console.WriteLine("\n--- Fin de la Demostración ---");

            Console.ReadKey();
        }
    }
}