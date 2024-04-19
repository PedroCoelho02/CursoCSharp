using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresRelacionais {
        public static void Executar() {
            //double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10.0); // > Maior que
            Console.WriteLine("Nota inválida? {0}", nota > 0.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0); // Igualdade
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0); // Diferente
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte); // Maior ou igual
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte); // Menor que
            Console.WriteLine("Reprovado? {0}", nota <= 3.0); // Menor ou igual

        }
    }
}
