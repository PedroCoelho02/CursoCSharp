﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() { 
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            // && Operador E
            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a TV 50'?{0}", comprouTv50);

            // || Operador Ou
            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            // ^ Operador de OU exclusivo
            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a TV 32'? {0}", comprouTv32);

            // ! Operador de negação logica
            Console.WriteLine("Mais saudavel? {0}", !comprouSorvete);
        }
    }
}
