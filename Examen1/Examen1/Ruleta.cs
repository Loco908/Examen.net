using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    public class Ruleta
    {
        List<int> numNegros = new List<int>();
        List<int> numRojos = new List<int>();  
        List<int> numPar = new List<int>();
        List<int> numRuleta = new List<int>();

        public Ruleta()
        {
            numNegros = new List<int>();
            numRojos = new List<int>();
            numPar = new List<int>();
            numRuleta = new List<int>();
        }

        public void showMenuPrincipal()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvendio a la ruleta, la cantidad minima para juegar es 300");
                Console.WriteLine("1. Tipo de tiro");
                Console.WriteLine("2.- Cuanto vas a apostar?");
            } while (!validaMenu(3, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1:showMenuAdminRuleta(); 
                    break;

                case 2: break;
                case 3: break;

            }
        }

        private void showMenuAdminRuleta()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvendio a la ruleta, ¿Que quieres ver?");
                Console.WriteLine("1.- Balance");
                Console.WriteLine("2.- Cantidad de giros realizados");
                Console.WriteLine("3.- Numero que más veces se ha tirado ");
                Console.WriteLine("4.- Numero que menos veces se ha tirado");
                Console.WriteLine("5.- Cantidad de resultados negros");
                Console.WriteLine("7.- Cantidad de resultados rojos");
                Console.WriteLine("8.- Cantidad de resultados pares");
                Console.WriteLine("9.- Cantidad de resultados impares");
                Console.WriteLine("10.- regresar");
            } while (!validaMenu(11, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1:
   
                    break;

                case 2: break;
                case 3: break;
                case 4: break;
                case 5: break;
                case 6: break;
                case 7: break;
                case 8: break;
                case 9: break;
                case 10: break;
            }
        }
        private bool validaMenu(int opciones, ref int opcionSeleccionada)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones)
                {
                    opcionSeleccionada = n;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opcion Invalida");
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El valor ingresado no es valido, debes ingresar un numero");
                return false;
            }
        }

        public void guardarNumColor()
        {
            for (int i = 0; i <= 36; i++)
            {
                if (i == 2 || i == 4 || i == 6 || i == 8 || i == 10 || i == 11 || i == 13 || i == 15 || i == 17 || i == 20 || i == 22 || i == 24 || i == 26 || i == 28 || i == 29 || i == 31 || i == 33 || i == 35)
                {
                    numNegros.Add(i);
                }
                else
                {
                    numRojos.Add(i);
                }

            }
        }


    }
}
