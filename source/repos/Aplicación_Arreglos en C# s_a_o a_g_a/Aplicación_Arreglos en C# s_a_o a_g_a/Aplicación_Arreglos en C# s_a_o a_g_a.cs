//Se tiene un grupo de N estudiantes identificados como 1, 2, 3... N; cada uno de ellos
//toma las mismas 8 materias: 1, 2, 3... 8; semestralmente, el profesor de cada materia
//reporta a la oficina de registros el código del estudiante, el número de la materia y la
//calificación obtenida. Elaborar un algoritmo que obtenga:
//• Las calificaciones promedio obtenidas por cada estudiante, mostradas en forma
//ascendente.
//• El promedio de notas en cada uno de 8 cursos.
//• El estudiante con mayor promedio.
using System;

class Program
{
    static void Main()
    {
        ProfeoEst();
    }

    static int[,] IngresoNotas()
    {
        int n, M;
        Console.WriteLine("Ingrese por favor la cantidad de estudiantes a registrar");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de materias a registrar por estudiante");
        M = int.Parse(Console.ReadLine());

        int[,] calificaciones = new int[n, M];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Ingrese el código del estudiante {i + 1}");
            int Codigo = int.Parse(Console.ReadLine());
            for (int j = 0; j < M; j++)
            {
                Console.WriteLine($"Ingrese la calificación de la materia {j + 1} para el estudiante {Codigo}");
                calificaciones[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return calificaciones;
    }

    static int Menu()
    {
        int opcion;
        Console.WriteLine("Bienvenido Profesor");
        Console.WriteLine("Seleccione la opción que desea realizar");
        Console.WriteLine("1. Ingreso de notas de estudiantes");
        Console.WriteLine("2. Salir");
        opcion = int.Parse(Console.ReadLine());
        return opcion;
    }

    static int MenuPpal()
    {
        int opcion;
        Console.WriteLine("------Bienvenido al colegio Master Class-------");
        Console.WriteLine("Este es el menú principal");
        Console.WriteLine("Seleccione su rol en la institución");
        Console.WriteLine("1. Profesor");
        Console.WriteLine("2. Estudiante");
        Console.WriteLine("3. Salir");
        opcion = int.Parse(Console.ReadLine());
        return opcion;
    }

    static void ProfeoEst()
    {
        int[,] calificaciones = null;
        int opcion;
        do
        {
            opcion = MenuPpal();
            switch (opcion)
            {
                case 1:
                    calificaciones = IngresoNotas();
                    break;
                case 2:
                    Console.WriteLine("Ha elegido salir, hasta pronto");
                    break;
                default:
                    Console.WriteLine("Opción no válida, inténtelo nuevamente");
                    break;
            }

            if (calificaciones != null && opcion == 1)
            {
                InfoEst(calificaciones);
            }
        } while (opcion != 3);
    }

    static int MenuEst()
    {
        int opcion;
        Console.WriteLine("------Bienvenido al colegio Master Class-------");
        Console.WriteLine("Este es el menú para estudiantes");
        Console.WriteLine("Seleccione la opción que desea realizar");
        Console.WriteLine("1. Consultar mi promedio");
        Console.WriteLine("2. Consultar mi nota en una materia");
        Console.WriteLine("3. Promedio de notas en cada curso");
        Console.WriteLine("4. Estudiante con el mayor promedio");
        Console.WriteLine("5. Salir");
        opcion = int.Parse(Console.ReadLine());
        return opcion;
    }

    static void InfoEst(int[,] calificaciones)
    {
        int opcion;

        do
        {
            opcion = MenuEst();
            switch (opcion)
            {
                case 1:
                    ConsultarNotaPorCodigo(calificaciones);
                    PromCaliEstu(calificaciones);
                    break;
                case 2:
                    ConsultarNotaPorCodigo(calificaciones);
                    break;
                case 3:
                    PromCurso(calificaciones);
                    break;
                case 4:
                    MayorPromedioPorEstudiante(calificaciones);
                    break;
                case 5:
                    Console.WriteLine("Ha elegido salir, hasta pronto");
                    break;
                default:
                    Console.WriteLine("Opción no válida, por favor ingrese una opción correcta");
                    break;
            }
        } while (opcion != 5);
    }

    static void ConsultarNotaPorCodigo(int[,] calificaciones)
    {
        int n = calificaciones.GetLength(0);
        int M = calificaciones.GetLength(1);

        Console.WriteLine("Ingrese el código del estudiante (por ejemplo, 01 para el Estudiante 1):");
        string codigo = Console.ReadLine();

        int estudianteIndex = -1; //se inicia en -1 ya que con esto logramos que el pograma busque el numero correcto e iniciamos en -1
                                  //ya que en una matriz un numero valido es un numero positivo


        for (int i = 0; i < n; i++)
        {
            if (codigo == $"{i + 1:D2}") //compara el formato del estudiante para poder comparar el dato ingresado y con D2 se evalua la expresion ya que
                                         //es un especificador de formato que formatea el número en una cadena
                                         //con un ancho fijo de 2 caracteres y rellena con ceros a la izquierda si es necesario.
            {
                estudianteIndex = i;
                break;
            }
        }

        if (estudianteIndex != -1) //si al finalizar la busqueda se encuentra que el estudianteindex es diferente ahora de -1 entonces se toma como valido. 
        {
            Console.WriteLine($"Notas del Estudiante {estudianteIndex + 1}:");
            for (int j = 0; j < M; j++)
            {
                Console.WriteLine($"Materia {j + 1}: {calificaciones[estudianteIndex, j]}");
            }
        }
        else
        {
            Console.WriteLine("Código de estudiante no encontrado.");
        }
    }

    static void PromCaliEstu(int[,] calificaciones)
    {
        int n = calificaciones.GetLength(0);
        int M = calificaciones.GetLength(1);
        Console.WriteLine("--------------Promedio de calificaciones---------------");

        for (int i = 0; i < n; i++)
        {
            double promedio = 0;
            for (int j = 0; j < M; j++)
            {
                promedio += calificaciones[i, j];
            }
            promedio /= M;
            Console.WriteLine($"Estudiante {i + 1} = {promedio}");
        }
    }

    static void PromCurso(int[,] calificaciones)
    {
        int n = calificaciones.GetLength(0);
        int M = calificaciones.GetLength(1);
        Console.WriteLine("------Promedio curso------");
        for (int j = 0; j < M; j++)
        {
            double promedio = 0;
            for (int i = 0; i < n; i++)
            {
                promedio += calificaciones[i, j];
            }
            promedio /= n;
            Console.WriteLine($"El promedio del curso {j + 1} = {promedio}");
        }
    }

    static void MayorPromedioPorEstudiante(int[,] calificaciones)
    {
        int n = calificaciones.GetLength(0);
        int M = calificaciones.GetLength(1);
        double PromMayor = double.MinValue;
        int PromEstMayor = -1;
        for (int i = 0; i < n; i++)
        {
            double promedio = 0;

            for (int j = 0; j < M; j++)
            {
                promedio += calificaciones[i, j];
            }
            promedio /= M;

            if (promedio > PromMayor)
            {
                PromMayor = promedio;
                PromEstMayor = i + 1;
            }

        }
    }

}
