using System;
using System.Globalization;


namespace ExercicioMembrosEstaticos {
    class Program {
        static void Main(string[] args) {


            /* Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa
               em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar
               6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.*/

            Console.Write("Qual é a cotação do dólar? ");
            double cotDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais: R$" + ConversorDeMoeda.Conversor(cotDolar, quant).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}