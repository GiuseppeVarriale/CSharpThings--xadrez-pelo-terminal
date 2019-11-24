using TabuleiroNS;

namespace XadrezNS
{
    class Peao : Peca
    {
        private PartidaDeXadrez _partida;
        public Peao(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            _partida = partida;
        }

        public override string ToString()
        {
            return "P";
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            if (Cor == Cor.Branca)
            {
                //N Direction 1
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && Livre(pos))
                {
                    matriz[pos.Linha, pos.Coluna] = true;
                }

                //N Direction 2
                pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && Livre(pos) && QteMovimentos == 0)
                {
                    matriz[pos.Linha, pos.Coluna] = true;
                }

                //NW
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    matriz[pos.Linha, pos.Coluna] = true;
                }
                //NE
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    matriz[pos.Linha, pos.Coluna] = true;
                }

                // #jogada especial en passant
                if (Posicao.Linha == 3)
                {
                    Posicao posicaoEsquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    if (Tab.PosicaoValida(posicaoEsquerda) && ExisteInimigo(posicaoEsquerda) && Tab.Peca(posicaoEsquerda) == _partida.VulneravelEnPassant)
                    {
                        matriz[posicaoEsquerda.Linha -1, posicaoEsquerda.Coluna] = true;
                    }
                    Posicao posicaoDireita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    if (Tab.PosicaoValida(posicaoDireita) && ExisteInimigo(posicaoDireita) && Tab.Peca(posicaoDireita) == _partida.VulneravelEnPassant)
                    {
                        matriz[posicaoDireita.Linha - 1 , posicaoDireita.Coluna] = true;
                    }
                }
            }

            else
            {
                //S Direction 1
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && Livre(pos))
                {
                    matriz[pos.Linha, pos.Coluna] = true;
                }

                //S Direction 2
                pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && Livre(pos) && QteMovimentos == 0)
                {
                    matriz[pos.Linha, pos.Coluna] = true;
                }

                //SW
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    matriz[pos.Linha, pos.Coluna] = true;
                }
                //SE
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    matriz[pos.Linha, pos.Coluna] = true;
                }

                // #jogada especial en passant
                if (Posicao.Linha == 4)
                {
                    Posicao posicaoEsquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    if (Tab.PosicaoValida(posicaoEsquerda) && ExisteInimigo(posicaoEsquerda) && Tab.Peca(posicaoEsquerda) == _partida.VulneravelEnPassant)
                    {
                        matriz[posicaoEsquerda.Linha +1, posicaoEsquerda.Coluna] = true;
                    }
                    Posicao posicaoDireita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    if (Tab.PosicaoValida(posicaoDireita) && ExisteInimigo(posicaoDireita) && Tab.Peca(posicaoDireita) == _partida.VulneravelEnPassant)
                    {
                        matriz[posicaoDireita.Linha + 1, posicaoDireita.Coluna] = true;
                    }
                }
            }
            return matriz;
        }

        private bool ExisteInimigo(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p != null && p.Cor != Cor;
        }

        private bool Livre(Posicao pos)
        {
            return Tab.Peca(pos) == null;
        }
    }
}
