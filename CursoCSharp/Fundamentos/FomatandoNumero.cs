using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FomatandoNumero {

        public static void Executar() {
            double valor = 12.175;
            Console.WriteLine(valor.ToString("F2")); // Casas decimais
            Console.WriteLine(valor.ToString("C")); // Tipo de moeda
            Console.WriteLine(valor.ToString("P")); // Porcentagem
            Console.WriteLine(valor.ToString("#.##")); // Casa decimal

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura)); // Altera o tipo de moeda

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Acrescenta casas
        }
    }
}
