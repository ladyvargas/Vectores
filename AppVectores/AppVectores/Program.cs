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
            Console.WriteLine("3 Elevado a la 4 es igual a: {0}", potencia(3,4));
            try
            {
                Console.WriteLine("5 Elevado a la 4 es igual a: {0}", potencia(-5, 4));
            }catch(Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message.ToString());
            }
            Console.WriteLine("2 Elevado a la 5 es igual a: {0}", potencia(2, 5));
            Console.ReadKey();
        }
    public static double potencia(double x, double y)
        {
            if (x <= 0)
                throw new Exception("X debe ser positivo");
            if (y<=0)
                throw new Exception("Y debe ser positivo");

        double po=1;
        for (int i=1; i<=y; i++)
        {
            po = po * x;
        }
        return po;
        }
}
}
