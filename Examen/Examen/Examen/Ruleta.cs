namespace Examen
{
    class Ruleta
    {
        private List<Giro> _giros;
        int? _dinero = 300;
        int? _balance = 0;
        int? _cantidadGiros = 0;
        int? _numerosNegros = 0;
        int? _numerosRojos = 0;
        int? _numerosPares = 0;
        int? _numerosImpares = 0;
        int dineroApuesta;
        int opcionSeleccionada = 0;

        public Ruleta()
        {
            _giros = new List<Giro>();
        }

        public void showMenuPrincipal()
        {
            
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvenido al casino. ¿Qué desea hacer?");
                Console.WriteLine("1.- Jugar a la ruleta.");
                Console.WriteLine("2.- Ver dinero disponible.");
                Console.WriteLine("3.- Ver historial de giros.");
                Console.WriteLine("4.- Consultar balance.");
                Console.WriteLine("5.- Salir.");

            } while (!validaMenu(5, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1:
                    showMenuRuleta();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Su saldo es de " + _dinero);
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadLine();
                    showMenuPrincipal();
                    break;

                case 3:
                    Console.Clear();
                    ListarGiros();
                    break;
                case 4:
                    Console.Clear();
                    _balance = _dinero - 300;
                    Console.WriteLine("Su balance es de " + _balance);
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadLine();
                    showMenuPrincipal();
                    break;
                case 5:
                    if (_balance < 0)
                    {
                        Console.WriteLine("Ha perdido " + _balance + " pesos");
                    }
                    else
                    {
                        Console.WriteLine("Ha ganado " + _balance + " pesos");
                    }
                    break;
            }
        }

        private void showMenuRuleta()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvenido al juego de la ruleta. ¿Qué tipo de apuesta desea realizar?");
                Console.WriteLine("1.- Apostar a un número en específico.");
                Console.WriteLine("2.- Apostar a un color.");
                Console.WriteLine("3.- Apostar a par o impar.");

            } while (!validaMenu(3, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1: showMenuApuesta1();
                    break;
                case 2: showMenuApuesta2();
                    break;
                case 3: showMenuApuesta3();
                    break;
            }
        }

        private void showMenuApuesta3()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvenido al juego de la ruleta. ¿Cuánto dinero desea apostar?");
                dineroApuesta = int.Parse(Console.ReadLine());
                if (dineroApuesta > _dinero)
                {
                    Console.WriteLine("No puede apostar más dinero de lo que tiene");
                }
            } while (dineroApuesta > _dinero);
            Console.WriteLine("¿Desea apostar por un número par o impar?");
            Console.WriteLine("1.- Par");
            Console.WriteLine("2.- Impar.");
            int numeroSeleccionado2 = int.Parse(Console.ReadLine());
            if (numeroSeleccionado2 == 1)
            {
                Random rand2 = new Random();
                int numeroAleatorio2 = rand2.Next(0, 36);
                Giro giro = new Giro(numeroAleatorio2);
                _giros.Add(giro);
                _cantidadGiros = _cantidadGiros + 1;
                if (numeroAleatorio2 % 2 == 0)
                {
                    _numerosPares = _numerosPares + 1;
                    _dinero = _dinero + (dineroApuesta * 2);
                    Console.WriteLine("Felicidades ha ganado, su nuevo saldo es " + _dinero);
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadLine();
                    showMenuPrincipal();
                }
                else
                {
                    _numerosImpares = _numerosImpares + 1;
                    _dinero = _dinero - dineroApuesta;
                    Console.WriteLine("Lo siento ha perdido, su nuevo saldo es " + _dinero);
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadLine();
                    showMenuPrincipal();
                }
            }
            else
            {
                Random rand2 = new Random();
                int numeroAleatorio2 = rand2.Next(0, 36);
                Giro giro = new Giro(numeroAleatorio2);
                _giros.Add(giro);
                _cantidadGiros = _cantidadGiros + 1;
                if (numeroAleatorio2 % 2 == 0)
                {
                    _numerosPares = _numerosPares + 1;
                    _dinero = _dinero - dineroApuesta;
                    Console.WriteLine("Lo siento ha perdido, su nuevo saldo es " + _dinero);
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadLine();
                    showMenuPrincipal();
                }
                else
                {
                    _numerosImpares = _numerosImpares + 1;
                    _dinero = _dinero + (dineroApuesta * 2);
                    Console.WriteLine("Felicidades ha ganado, su nuevo saldo es " + _dinero);
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadLine();
                    showMenuPrincipal();
                }
            }

        }

        private void showMenuApuesta2()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvenido al juego de la ruleta. ¿Cuánto dinero desea apostar?");
                dineroApuesta = int.Parse(Console.ReadLine());
                if (dineroApuesta > _dinero)
                {
                    Console.WriteLine("No puede apostar más dinero de lo que tiene");
                }
            } while (dineroApuesta > _dinero);
            Console.WriteLine("¿Desea apostar por el color rojo o por el color negro?");
            Console.WriteLine("1.- Rojo.");
            Console.WriteLine("2.- Negro.");
            int numeroSeleccionado2 = int.Parse(Console.ReadLine());
            if (numeroSeleccionado2 == 2)
            {
                Random rand2 = new Random();
                int numeroAleatorio2 = rand2.Next(0, 36);
                Giro giro = new Giro(numeroAleatorio2);
                _giros.Add(giro);
                _cantidadGiros = _cantidadGiros + 1;
                if (numeroAleatorio2 % 2 == 0)
                {
                    _numerosPares = _numerosPares + 1;
                }
                else
                {
                    _numerosImpares = _numerosImpares + 1;
                }
                if (numeroSeleccionado2 == 1 || numeroSeleccionado2 == 3 || numeroSeleccionado2 == 5 || numeroSeleccionado2 == 7 || numeroSeleccionado2 == 9
                    || numeroSeleccionado2 == 12 || numeroSeleccionado2 == 14 || numeroSeleccionado2 == 16 || numeroSeleccionado2 == 18 || numeroSeleccionado2 == 19
                    || numeroSeleccionado2 == 21 || numeroSeleccionado2 == 23 || numeroSeleccionado2 == 25 || numeroSeleccionado2 == 27
                    || numeroSeleccionado2 == 30 || numeroSeleccionado2 == 32 || numeroSeleccionado2 == 34 || numeroSeleccionado2 == 36)
                {
                    _numerosRojos = _numerosRojos + 1;
                    _dinero = _dinero - dineroApuesta;
                    Console.WriteLine("Lo siento ha perdido, su nuevo saldo es " + _dinero);
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadLine();
                    showMenuPrincipal();
                }
                else
                {
                    _dinero = _dinero + (dineroApuesta * 5);
                    _numerosNegros = _numerosNegros + 1;
                    Console.WriteLine("Felicidades ha ganado, su nuevo saldo es " + _dinero);
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadLine();
                    showMenuPrincipal();
                }
            }
            if (numeroSeleccionado2 == 1)
            {
                Random rand2 = new Random();
                int numeroAleatorio2 = rand2.Next(0, 36);
                Giro giro = new Giro(numeroAleatorio2);
                _giros.Add(giro);
                _cantidadGiros = _cantidadGiros + 1;
                if (numeroAleatorio2 % 2 == 0)
                {
                    _numerosPares = _numerosPares + 1;
                }
                else
                {
                    _numerosImpares = _numerosImpares + 1;
                }
                if (numeroSeleccionado2 == 1 || numeroSeleccionado2 == 3 || numeroSeleccionado2 == 5 || numeroSeleccionado2 == 7 || numeroSeleccionado2 == 9
                    || numeroSeleccionado2 == 12 || numeroSeleccionado2 == 14 || numeroSeleccionado2 == 16 || numeroSeleccionado2 == 18 || numeroSeleccionado2 == 19
                    || numeroSeleccionado2 == 21 || numeroSeleccionado2 == 23 || numeroSeleccionado2 == 25 || numeroSeleccionado2 == 27
                    || numeroSeleccionado2 == 30 || numeroSeleccionado2 == 32 || numeroSeleccionado2 == 34 || numeroSeleccionado2 == 36)
                {
                    _numerosRojos = _numerosRojos + 1;
                    _dinero = _dinero + (dineroApuesta * 5);
                    Console.WriteLine("Felicidades ha ganado, su nuevo saldo es " + _dinero);
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadLine();
                    showMenuPrincipal();
                }
                else
                {
                    _numerosNegros = _numerosNegros + 1;
                    _dinero = _dinero - dineroApuesta;
                    Console.WriteLine("Lo siento ha perdido, su nuevo saldo es " + _dinero);
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadLine();
                    showMenuPrincipal();
                }
            }

        }
        private void showMenuApuesta1()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvenido al juego de la ruleta. ¿Cuánto dinero desea apostar?");
                dineroApuesta = int.Parse(Console.ReadLine());
                if (dineroApuesta > _dinero)
                {
                    Console.WriteLine("No puede apostar más dinero de lo que tiene");
                }
            } while (dineroApuesta > _dinero);
            Console.WriteLine("¿A qué número le apuesta?");
            int numeroSeleccionado = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int numeroAleatorio = rand.Next(0, 32);
            Giro giro = new Giro(numeroAleatorio);
            _giros.Add(giro);
            _cantidadGiros = _cantidadGiros + 1;
            if (numeroAleatorio % 2 == 0)
            {
                _numerosPares = _numerosPares + 1;
            }
            else
            {
                _numerosImpares = _numerosImpares + 1;
            }
            if (numeroSeleccionado == numeroAleatorio)
            {
                _dinero = _dinero + (dineroApuesta * 10); 
                Console.WriteLine("Felicidades ha ganado, su nuevo saldo es " + _dinero);
                Console.WriteLine("Presione enter para continuar");
                Console.ReadLine();
                showMenuPrincipal();
            }
            else
            {
                _dinero = _dinero - dineroApuesta;
                Console.WriteLine("Lo siento, ha perdido, su nuevo saldo es " + _dinero);
                Console.WriteLine("El número ganador era " + numeroAleatorio);
                Console.WriteLine("Presione enter para continuar");
                Console.ReadLine();
                showMenuPrincipal();
            }


        }
        private void ListarGiros()
        {
            Console.WriteLine("Números obtenidos en los giros.");
            Console.WriteLine("\n");
            foreach (Giro item in _giros)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\n");
            Console.WriteLine("Ha realizado " + _cantidadGiros + " giros");
            Console.WriteLine("\n");
            Console.WriteLine("Se han obtenido " + _numerosRojos + " números rojos y " + _numerosNegros + " números negros");
            Console.WriteLine("\n");
            Console.WriteLine("Se han obtenido " + _numerosPares + " números pares y " + _numerosImpares + " números impares");
            Console.WriteLine("\n");
            Console.WriteLine("Presiona enter para continuar.");
            Console.ReadLine();
            showMenuPrincipal();
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
                    Console.WriteLine("Opción inválida");
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El valor ingresado no es válido");
                return false;
            }
        }

    }
}
