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

        public Peca Peca(int linha, int coluna)
        {
            return _Pecas[linha, coluna];
        }
        public void ColocarPeca(Peca p, Posicao pos) 
        {
            _Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
    }
}
