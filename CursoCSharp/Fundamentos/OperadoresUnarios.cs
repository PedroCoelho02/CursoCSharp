using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;    
            var boolean = true;

            Console.WriteLine(-valorNegativo); //Inverte o sinal
            Console.WriteLine(!boolean);//Negação

            //Incremento
            numero1++;
            Console.WriteLine(numero1);

            //Decremento
            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
