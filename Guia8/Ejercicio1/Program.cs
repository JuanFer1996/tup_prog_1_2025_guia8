namespace Ejercicio1
{
    internal class Program
    {
        #region atributos
        static int contador;
        static int acumulador;
        static int maximo;
        static int minimo;
        #endregion
        #region metodos pantalla
        static void RegistrarValor(int valor)
        {
            acumulador += valor;
            if (valor > maximo || contador == 0)
            {
                maximo = valor;
            }
            if (valor < minimo || contador == 0)
            {

                minimo = valor;
            }
            contador += 1;

        }
        static double CalcularPromedio()
        {
            double valor = 0;
            if (contador > 0)
            {
                valor = 1d * acumulador / contador;
            }
            return valor;
        }
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();

            Console.WriteLine(" 1- Procesar un solo número");
            Console.WriteLine(" 2- Procesar varios númerosn");
            Console.WriteLine(" 3- Mostrar máximo y mínimo.");
            Console.WriteLine(" 4- Mostrar promedio.");
            Console.WriteLine(" 5- Mostrar cantidad de números ingresados.");
            Console.WriteLine(" 6- Reiniciar variables.");
            int opc = Convert.ToInt32(Console.ReadLine());

            return opc;
        }
        static void MostrarIniciarVariables()
        {
        }
        static void MostrarPantallaSolicitarNumero()
        {
            Console.Clear();
            Console.WriteLine("ingrese un numero");
            RegistrarValor(Convert.ToInt32(Console.ReadLine()));
        }
        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de valores a cargar");
            int cant = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("ingrese valor");
                RegistrarValor(Convert.ToInt32(Console.ReadLine()));
            }
        }
        static void MostrarPantallaMaximoYMinimo()
        {
            Console.Clear();

            Console.WriteLine($"valor maximo {maximo} valor minimo {minimo}");

            Console.ReadKey();
        }

        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            Console.Clear();
            double Prom = CalcularPromedio();
            Console.WriteLine($"promedio: {Prom}");
            Console.ReadKey();
        }
        static void MostrarPantallaCantidad()
        {
            Console.Clear();
            Console.WriteLine($"Se ingresaron {contador} valores ");
            Console.ReadKey();
        }
        #endregion
        static void Main(string[] args)
        {
            acumulador = 0;
            contador = 0;

            int op = MostrarPantallaSolicitarOpcionMenu();
            while (op != -1)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarNumero();
                        break;

                    case 2:
                        MostrarPantallaSolicitarVariosNumeros();

                        break;

                    case 3:
                        MostrarPantallaMaximoYMinimo();
                        break;

                    case 4:
                        MostrarPantallaCalcularYMostrarPromedio();
                        break;

                    case 5:
                        MostrarPantallaCantidad();
                        break;
                    case 6:
                        acumulador = 0;
                        contador = 0;
                        maximo = 0;
                        minimo = 0;
                        break;
                    default:
                        op = -1;
                        break;


                }
                if (op != -1)
                    op = MostrarPantallaSolicitarOpcionMenu();
            }



        }
    }
}

