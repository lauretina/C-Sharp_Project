using System;

namespace PAC_desarrollo_UF1
{
    class Program
    {
        static void Main(string[] args)

        {
            // declarar variables
            int fila1, columna1, fila2, columna2;
            string linea;
            Console.WriteLine("¿Cuántas filas quieres que tenga la primera matriz?:");
            linea = Console.ReadLine();
            fila1 = int.Parse(linea);

            Console.WriteLine("¿Cuántas columnas quieres que tenga la primera matriz?:");
            linea = Console.ReadLine();
            columna1 = int.Parse(linea);

            // declarar matriz1
            int[,] mat1 = new int[fila1, columna1];

            //introducir elementos de la primera matriz

            for (int f = 0; f < fila1; f++)
            {
                for (int c = 0; c < columna1; c++)
                {
                    Console.Write("Para la primera matriz introduce el elemento ({0},{1}):", (f + 1), (c + 1));
                    linea = Console.ReadLine();
                    mat1[f, c] = int.Parse(linea);
                }

            }

            //Mostrar la primera matriz
            Console.WriteLine("La primera matriz es la siguiente:");
            for (int f = 0; f < fila1; f++)
            {
                Console.Write(" ( ");
                for (int c = 0; c < columna1; c++)
                {
                    Console.Write(" {0} ", mat1[f, c]);
                }
                Console.Write(" ) \n");
            }

            Console.WriteLine("¿Cuántas filas quieres que tenga la segunda matriz?:");
            linea = Console.ReadLine();
            fila2 = int.Parse(linea);
            Console.WriteLine("¿Cuántas columnas quieres que tenga la segunda matriz?:");
            linea = Console.ReadLine();
            columna2 = int.Parse(linea);

            // declarar matriz2
            int[,] mat2 = new int[fila2, columna2];

            //introducir elementos de la segunda matriz

            for (int f = 0; f < fila2; f++)
            {
                for (int c = 0; c < columna2; c++)
                {
                    Console.Write("Para la segunda matriz introduce el elemento ({0},{1}):", (f + 1), (c + 1));
                    linea = Console.ReadLine();
                    mat2[f, c] = int.Parse(linea);
                }
            }

            //Mostrar la segunda matriz
            Console.WriteLine();
            Console.WriteLine("La segunda matriz es la siguiente:");
            for (int f = 0; f < fila2; f++)
            {
                Console.Write(" ( ");
                for (int c = 0; c < columna2; c++)
                {
                    Console.Write(" {0} ", mat2[f, c]);

                }
                Console.Write(" ) \n");
            }

            //Comparar matrices
            if (fila1 == fila2 && columna1 == columna2)
            {
                Console.WriteLine("Las matrices pueden ser comparadas");
                Console.WriteLine();

                //Iguales o no
                bool iguales = true;
                for (int f = 0; f < fila1; f++)
                {
                    for (int c = 0; c < columna1; c++)
                    {
                        if (mat1[f, c] != mat2[f, c])
                        {
                            iguales = false;
                            break;
                        }
                    }
                }
                if (iguales)
                {
                    Console.WriteLine("Las matrices son iguales");
                }
                else
                    Console.WriteLine("Las matrices no son iguales");
            }
            else Console.WriteLine("Las matrices no pueden ser comparadas");
        }
    }
}
