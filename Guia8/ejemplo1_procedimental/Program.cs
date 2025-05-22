namespace ejemplo1_procedimental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prom = 0;
            int valor, cantidad, valorMin = 0, valorMax = 0, contador = 0, acumulador = 0;
            Console.WriteLine("ingrse cantidad de ingresos");
            cantidad = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("ingrese valor");
                valor = Convert.ToInt32(Console.ReadLine());
                acumulador += valor;
                if (valor > valorMax || contador == 0)
                {
                    valorMax = valor;
                }
                if (valor < valorMin || contador == 0)
                {
                    valorMin = valor;
                }
                contador += 1;

            }
            if (acumulador > 0)
            {
                prom = 1d*acumulador / cantidad;
            }
            Console.WriteLine($"valor mañximo {valorMax} valor minimo {valorMin} promedio {prom}");
        }
    }
}
