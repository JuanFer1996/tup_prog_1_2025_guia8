namespace Ejercicio2
{
    internal class Program
    {
        #region atributos
        static int edad0;
        static int edad1;
        static int edad2;
        static int edad3;
        static double monto;
        static double porcentaje0;
        static double porcentaje1;
        static double porcentaje2;
        static double porcentaje3;
        static double monto0;
        static double monto1;
        static double monto2;
        static double monto3;
        #endregion

        #region metodos pantalla
        static void RegistrarMontoARepartir(double monto)
        {
            Program.monto = monto;
        }
        static void RegistrarEdad(int edad, int nroNiña)
        {
            switch (nroNiña)
            {
                case 0:
                    edad0 = edad;
                    break;
                case 1:
                    edad1 = edad;
                    break;
                case 2:
                    edad2 = edad;
                    break;
                case 3:
                    edad3 = edad;
                    break;

            }

        }
        static void CalcularMontosYPorcentajesARepartir()
        {
            porcentaje0 = (edad0 * 1.0 / (edad0 + edad1 + edad2 + edad3)) * 100;
            porcentaje1 = (edad1 * 1.0 / (edad0 + edad1 + edad2 + edad3)) * 100;
            porcentaje2 = (edad2 * 1.0 / (edad0 + edad1 + edad2 + edad3)) * 100;
            porcentaje3 = (edad3 * 1.0 / (edad0 + edad1 + edad2 + edad3)) * 100;
            monto0 = (monto * porcentaje0) / 100;
            monto1 = (monto * porcentaje1) / 100;
            monto2 = (monto * porcentaje2) / 100;
            monto3 = (monto * porcentaje3) / 100;

        }
        static int MostrarPantalaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine(" 1- Iniciar monto a repartir");
            Console.WriteLine(" 2- Solicitar edad por niña");
            Console.WriteLine(" 3- Mostrar montos y porcentajes que corresponden a cada niña");
            int opc = Convert.ToInt32(Console.ReadLine());
            return opc;
        }

        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("ingrese el monto a repartir");
            RegistrarMontoARepartir(Convert.ToDouble(Console.ReadLine()));
        }
        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            Console.Clear();
            Console.WriteLine("ingrese el numero de la niña ");
            int nroNiña = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la edad de niña ");
            RegistrarEdad(Convert.ToInt32(Console.ReadLine()), nroNiña);
        }
        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            Console.Clear();
            Console.WriteLine("Monto niña 0: " + monto0 + " porcentaje: " + porcentaje0);
            Console.WriteLine("Monto niña 1: " + monto1 + " porcentaje: " + porcentaje1);
            Console.WriteLine("Monto niña 2: " + monto2 + " porcentaje: " + porcentaje2);
            Console.WriteLine("Monto niña 3: " + monto3 + " porcentaje: " + porcentaje3);
            Console.ReadKey();
        }

        #endregion

        static void Main(string[] args)
        {
            int op = MostrarPantalaSolicitarOpcionMenu();
            while (op != -1)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarMontoARepartir();
                        break;
                    case 2:
                        for (int i = 0; i < 4; i++)
                        {
                            MostrarPantallaSolicitarEdadesNiñas();
                        }
                        break;
                    case 3:
                        CalcularMontosYPorcentajesARepartir();
                        MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña();
                        break;
                    default:
                        op = -1;
                        break;

                }
                if (op != -1)
                {
                    op = MostrarPantalaSolicitarOpcionMenu();
                }
            }
        }
    }
}
