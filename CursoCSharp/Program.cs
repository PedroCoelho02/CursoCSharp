using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Formatando Numeros - Fundamentos", FomatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmericos - Fundamentos", OperadoresAritmericos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternarios - Fundamentos", OperadorTernario.Executar},

                //Estrura de Controle
                {"Estrutura de Controle - IF", EstruturaIf.Executar},
                {"Estrutura de Controle - IF/Else", EstruturaIfElse.Executar},
                {"Estrutura de Controle - IF/Else If", EstruturaIfElseIf.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}