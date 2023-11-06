using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiantes
{
    public class Student
    {
       

            //Atributos
            private string nombre;
            private int edad;
            private int numeroEstudiante;

            //Constructor
            public Student(string nombre, int edad, int numeroEstudiante)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.numeroEstudiante = numeroEstudiante;
            }

            //Propiedades publicas para acceder a los atributos privados 
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            public int Edad
            {
                get { return edad; }
                set { edad = value; }
            }
            public int NumeroEstudiante
            {
                get { return numeroEstudiante; }
                set { numeroEstudiante = value; }
            }

            public override string ToString()
            {
                return $"Nombre del estudiante: {nombre}, Edad: {edad}, Numero de Estudiante: {numeroEstudiante}";
            }

            public void MostrarDatos()
            {
            Console.WriteLine($"Nombre del Estudiante: {nombre}, Edad del estudiante: {edad}, Numero del Estudiante: {numeroEstudiante}");
            }
            public int ObtenerEdad()
            { 
            return edad; 
            }
            public int ObtenerNumerosEstudiante()
            { 
            return numeroEstudiante; 
            }
     }
}
