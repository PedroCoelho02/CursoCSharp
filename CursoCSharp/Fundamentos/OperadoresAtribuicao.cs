using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAtribuicao {
        public static void Executar() {
            var num1 = 3;
            num1 = 7;
            num1 += 10; // Atribuição do tipo adição
            num1 -= 6; // Atribuição do tipo subração
            num1 *= 5; // Atribuição do tipo multiplicação
            num1 /= 4; // Atribuiçao do tipo divisão

            Console.WriteLine(num1);
        }
    }
}
