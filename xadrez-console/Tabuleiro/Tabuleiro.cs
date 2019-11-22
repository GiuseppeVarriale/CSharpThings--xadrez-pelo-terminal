using System;
using System.Collections.Generic;
using System.Text;

namespace TabuleiroNS
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] _Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            _Pecas = new Peca[linhas, colunas];
        }
    }
}
