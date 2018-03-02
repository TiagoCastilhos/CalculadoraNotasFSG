using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFSG {
    class Nota1 {
        double nota;
        double porcentagem;

        public Nota1(double nota, double porcentagem)
        {
            this.nota = nota;
            this.porcentagem = porcentagem / 100;
        }

        public double CalcularNota(double nota, double porcentagem)
        {
            nota = this.nota;
            porcentagem = this.porcentagem;

            return nota * porcentagem;
        }

        public static double SomaDeNotas(double Nota1, double Nota2, double Nota3)
        {
            return Nota1 + Nota2 + Nota3;
        }

    }
}
