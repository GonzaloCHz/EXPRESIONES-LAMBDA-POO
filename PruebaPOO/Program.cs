using System;
using System.Collections.Generic;
using System.Linq;

namespace PruebaPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            // List with eah element of type Student 
            List<Estudiante> details = new List<Estudiante>() {
            new Estudiante{ Id = 1, Nombre = "Liza", Apellido="Zambrano", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Stewart",  Apellido="Rivera",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Tina",  Apellido="Mendoza",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Stefani",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Trish",  Apellido="Restrepo",Promedio= 3, Edad=23  }
        };
            Console.WriteLine("============================LISTA DE ESTUDIANTES==================================");
            Console.WriteLine("");
            Console.WriteLine("Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor");
            //2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor
            Console.WriteLine("");
            List<string> estudiantes = (from datos in details
                                  orderby datos.Promedio descending
                                  select (datos.Promedio+"--"+datos.Nombre+" "+datos.Apellido)).ToList();
            Console.WriteLine(string.Join("\n",estudiantes));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Muestre por pantalla los nombres de los estudiantes");
            //1. Muestre por pantalla los nombres de los estudiantes
            Console.WriteLine("");
            List<string> estudiantes2 = (from datos in details
                                  orderby datos.Nombre
                                  select (datos.Nombre)).ToList();
            Console.WriteLine(string.Join("\n", estudiantes2));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente");
            //3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente
            Console.WriteLine("");
            List<string> estudiantes3 = (from datos in details
                                   orderby datos.Apellido ascending
                                   select (datos.Apellido)).ToList();
            Console.WriteLine(string.Join("\n", estudiantes3));

            //4. Muestre por pantalla los datos del estudiante mas joven
            Console.WriteLine("");
            
            Console.WriteLine("Muestre por pantalla los datos del estudiante mas joven");
            Console.WriteLine("");
            var edadmenor = details.Min(x => x.Edad+" "+x.Nombre+" "+x.Apellido+" "+x.Promedio);
            Console.WriteLine(edadmenor);
            Console.WriteLine("");

            Console.WriteLine("===============================Lista de numeros==========================================");
            Console.WriteLine(" ");
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla el cuadrado de los números
            Console.WriteLine("1. Muestre por pantalla el cuadrado de los números");           
            var cuadrado = list.Select(x => x * x);
            Console.WriteLine(string.Join(" ", cuadrado));
            //2. Muestre por pantalla los números pares
            Console.WriteLine("");
            Console.WriteLine("Muestre por pantalla los números pares");
            List<int >NumPares = list.FindAll(i => i %  2== 0);
            Console.WriteLine(string.Join(" ", NumPares));
            Console.WriteLine("");
            //3.Muestre por pantalla el resultado de multiplicar por 5 los numero impares
            Console.WriteLine("Muestre por pantalla el resultado de multiplicar por 5 los numero impares");
            List<int> NumIn = list.FindAll(i => i % 2 != 0);
            var multiplicador = NumIn.Select(x => x * 5);

            Console.WriteLine(string.Join(" ", multiplicador));
        }
    }
}
    
