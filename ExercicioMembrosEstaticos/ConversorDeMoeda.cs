using System;
using System.Globalization;

namespace ExercicioMembrosEstaticos {
    internal class ConversorDeMoeda {

        public static double Conversor(double cot, double valor) {
            double valorReal = cot * valor;
            valorReal += valorReal * 0.06;
            return valorReal;
        }

    }
}
