﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui um bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            ////if(entrada == "S" || entrada == "s") {
            //    bomComportamento = true;
            //    }
            //

            bomComportamento = entrada.ToLower() == "s";

            if(nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra");
            }
            if(nota < 9.0) {
                Console.WriteLine("Não está no quado de honra");
            }
        }
    }
}
