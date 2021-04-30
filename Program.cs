using System;

namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            float prestamo_valor,

            saldado,
           interesPagado,
            tia,
            saldo,
            tim;

            int tabla,
            plazo,
            x;
            // Variable tia = Tasa interes Anual
            // Variable tim = Tasa interes Mensual

            Console.Write("Cúal es el valor del préstamo?: ");
            float.TryParse(Console.ReadLine(), out prestamo_valor);

            Console.Write("Cuál es la tasa de interés anual (TIA)?: ");
            float.TryParse(Console.ReadLine(), out tia);

            Console.Write("Cuantos meses?: ");
            int.TryParse(Console.ReadLine(), out plazo);

            tim = (tia / 100) / 12;

            saldo = tim + 1;
            saldo = (float)Math.Pow(saldo, plazo);
            saldo = saldo - 1;
            saldo = tim / saldo;
            saldo = tim + saldo;
            saldo = prestamo_valor * saldo;

            Console.WriteLine();
            tabla = 1;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Numero de pago \t");
            Console.Write("Cantidad saldada \t\t");
            Console.Write("Intereses Pagados \t\t");
            Console.Write("Pagado \t\t");
            Console.Write("Balance adeudado \t");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\t0");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + prestamo_valor + "");

            for (x = 1; x <= plazo; x++)
            {
                Console.Write("\t" + tabla + "\t\t");
                Console.Write("" + saldo + "\t");

                interesPagado = tim * prestamo_valor;
                Console.Write("" + interesPagado + "\t\t");

                saldado = saldo - interesPagado;
                Console.Write("\t" + saldado + "\t");

                prestamo_valor = prestamo_valor - saldado;
                Console.Write("\t" + prestamo_valor + "\t");

                tabla = tabla + 1;
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}