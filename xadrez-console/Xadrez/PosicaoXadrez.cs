using TabuleiroNS;
namespace XadrezNS
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a'); // 'a' - 'a' = 0   'b' - 'a' = 1 ( internamente é como um ascii) 
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
