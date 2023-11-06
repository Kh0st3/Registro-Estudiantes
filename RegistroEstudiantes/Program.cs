using System;
using System.Collections.Generic;

namespace RegistroEstudiantes
{
    

        public class Program 
        {
            static List<Student> students = new List<Student>();

            public static void Main(string[] args)
            {
                bool continuar = true;

                while (continuar) 
                {
                    Console.WriteLine("1. Ingresar estudiante");
                    Console.WriteLine("2. Visualizar estudiantes");
                    Console.WriteLine("3. Eliminar estudiante");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("Seleccione una opcion: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            AgregarEstudiante();
                            break;
                        case 2:
                            MostrarDatos();
                        break;
                        case 3:
                            EliminarEstudiante();
                        break;
                        case 4:
                            continuar = false;
                        break;
                        default:
                        Console.WriteLine("Opcion no valida. Intente nuevamente.");
                        break;
                    }
                }
            }
            static void AgregarEstudiante()
            {
                Console.WriteLine("Ingrese el nombre completo del estudiante:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la edad del estudiante:");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el numero del estudiante:");
                int numeroEstudiante = Convert.ToInt32(Console.ReadLine());

                Student student = new Student(nombre, edad, numeroEstudiante);
                students.Add(student);

            Console.WriteLine("*******Estudiante ha sigo ingresado correctamente*******");
            }
            static void MostrarDatos()
            {
            Console.WriteLine("Lista de estudiantes:");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
            }
            static void EliminarEstudiante()
            {
            Console.WriteLine("Ingrese el numero del estudiante a eliminar: ");
            int numeroEstudiante = Convert.ToInt32(Console.ReadLine());

            Student estudianteAEliminar = students.Find(student => student.NumeroEstudiante == numeroEstudiante);

            if (estudianteAEliminar != null)
            {
                students.Remove(estudianteAEliminar);
                Console.WriteLine("*******Estudiante eliminado correctamente.*******");
            }
            else
            {
                Console.WriteLine("*******Estudiante no encontrado.*******");
            }
            }
        }
}
