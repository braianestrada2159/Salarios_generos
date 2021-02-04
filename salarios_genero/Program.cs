using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarios_genero
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int sexo;
            int mujeres;
            int hombres;
            int contador;
            int folio;
            int sueldo;

            mujeres = 0;
            hombres = 0;
            contador = 1;

            for (int i = 0; i <= 10; i++) ;
            {
                //datos de entrada
                Console.WriteLine("Por favor digite el numero de folio de la persona #" + contador);
                folio = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Por favor digite el sueldo de la persona #" + contador);
                sueldo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Por favor digite 1 es mujer o 2 si es hombre:");

                //proceso
                sexo = Convert.ToInt32(Console.ReadLine());

                if (sexo == 1 && sueldo > 900000)
                {
                    mujeres += 1;
                }
                else if (sexo == 2 && sueldo < 1000000)
                {
                    hombres += 1;
                }
                contador += 1;
            }

            //Datos de salida
            Console.WriteLine("La cantidad de mujeres que ganan mas de 900000 pesos son:" + mujeres);
            Console.WriteLine("La cantidad de hombres que ganan menos de 1000000 pesos son:" + hombres);
        }
    }
}
