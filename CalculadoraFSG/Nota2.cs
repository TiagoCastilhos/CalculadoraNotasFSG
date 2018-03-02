using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFSG {
    class Nota2 {
        double NotaAPS;

        public Nota2 (double nota)
        {
            
            NotaAPS = nota;
        }

        public double CalculoAPS(double nota)
        {
            return nota * 0.2;
        }
    }
}
