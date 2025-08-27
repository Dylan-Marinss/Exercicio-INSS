using System.Globalization;

namespace INSS
{
    public class Program
    {
        static void Main(string[] args)
        {
            DetalharData();
            CalcularDescontoINSS();
        }

        public static void DetalharData()
        {
            Console.WriteLine("Digite aqui uma data: ");
            DateTime dia = DateTime.Parse(Console.ReadLine());
            string diaSemana = dia.ToString("dddd", new CultureInfo("pt-BR"));
            string Mes = dia.ToString("MMMM", new CultureInfo("pt-BR"));
            if (dia.DayOfWeek == DayOfWeek.Sunday)
            {
                string Hora = DateTime.Now.ToString("hh:mm:ss");
                Console.WriteLine($"{Hora}");
            }

            Console.WriteLine($"{diaSemana}");
            Console.WriteLine($"{Mes}");
        }

        public static void CalcularDescontoINSS()
        {
            System.Console.WriteLine("Digite seu salário: ");
            double Salario = Double.Parse(Console.ReadLine());
            Double desconto = 0;
            Double descontoExibido = 0;

            if (Salario <= 1212.00)
            {
                descontoExibido = 7.5;
                desconto = Salario * 0.075;
            }
            else if (Salario <= 2427.35)
            {
                descontoExibido = 9;
                desconto = Salario * 0.09;
            }
            else if (Salario <= 3641.03)
            {
                descontoExibido = 12;
                desconto = Salario * 0.12;
            }
            else if (Salario <= 7087.22)
            {
                descontoExibido = 14;
                desconto = Salario * 0.14;
            }

            double SalarioLiquido = Salario - desconto;
            System.Console.WriteLine($"Desconto aplicado: {descontoExibido}%");
            System.Console.WriteLine($"Desconto do INSS: R${desconto.ToString("F2")}");
            Console.WriteLine("Salário líquido: R$ " + SalarioLiquido.ToString("F2"));
        }

    }

}
