using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control de versiones1");
            Console.WriteLine("Control de versiones2");
            Console.WriteLine("Control de versiones3");
            Console.WriteLine("Control de versiones4");
            Console.WriteLine("Control de versiones5");
            Console.WriteLine("Probando control de versiones");
            Console.WriteLine("3 Elevado a la 4 es igual a: {0}", potencia(3, 4));
            try
            {
                Console.WriteLine("5 Elevado a la 4 es igual a: {0}", potencia(-5, 4));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message.ToString());
            }
            Console.WriteLine("2 Elevado a la 5 es igual a: {0}", potencia(2, 5));
            vectorInicializar();
            vector_clases();
            Console.ReadKey();

        }
        public static double potencia(double x, double y)
        {
            if (x <= 0)
                throw new Exception("X debe ser positivo");
            if (y <= 0)
                throw new Exception("Y debe ser positivo");

            double po = 1;
            for (int i = 1; i <= y; i++)
            {
                po = po * x;
            }
            return po;
        }

        public static void vectorInicializar()
        {
            Console.WriteLine("\nELEMENTOS DEL VECTOR\n***************\n");
            int[] x = new int[8];
            x[0] = 10;
            x[1] = 2;
            x[2] = 20;
            x[3] = 8;
            x[4] = 15;
            x[5] = 1;
            x[6] = -9;
            x[7] = 14;
            for (int i = 0; i< 8; i++)
            {
                Console.WriteLine("Elemento indice {0} ---> {1}", (i + 1), x[i]);
            }

            int suma = 0;
            for (int i = 0; i < x.Length; i++)
            {
                suma = suma + x[i];
            }
            Console.WriteLine("La sumatoria es {0}", suma);
            Console.WriteLine("El promedio es {0}", (double)suma/x.Length);
        }


        public static void vector()
        {
            Console.WriteLine("\nELEMENTOS DEL VECTOR\n***************\n");
            int[] x = new int[9];
            int max = x[0], min = x[0];
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Ingrese el {0} numero", (i + 1));
                x[i] = int.Parse(Console.ReadLine());

                for (int y = 0; y < 9; y++)
                {
                    if (!(x[i] >= 1 && x[i] <= 1000))
                    {
                        Console.WriteLine("Ingrese nuevamente el numero {0}", (i + 1));
                        x[i] = int.Parse(Console.ReadLine());
                    }
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (x[i] > max)

                    max = x[i];


                else if (x[i] < min)

                    min = x[i];
            }
            Console.WriteLine("El numero mayor es = {0}", max);
            Console.WriteLine("El numero menor es = {0}", min);
        }

        public static void vector_clases()
        {
            Console.WriteLine("\nELEMENTOS DEL VECTOR\n***************\n");
            int[] x = new int[9];
            int max = x[0], min = x[0];
            for (int i = 0; i < 9; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese el {0} numero", (i + 1));
                    x[i] = int.Parse(Console.ReadLine());

                    if (!(x[i] >= 1 && x[i] <= 1000))
                    {
                        Console.WriteLine("Ingrese nuevamente el numero {0}", (i + 1));
                        x[i] = int.Parse(Console.ReadLine());
                    }
                } while (!(x[i] >= 1 && x[i] <= 1000));
            }
            for (int i = 0; i < 9; i++)
            {
                if (x[i] > max)

                    max = x[i];


                else if (x[i] < min)

                    min = x[i];
            }
            Console.WriteLine("El numero mayor es = {0}", max);
            Console.WriteLine("El numero menor es = {0}", min);
        }
    }

    }

