using TabuleiroNS;
using XadrezNS;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            System.Console.WriteLine(pos);
            System.Console.WriteLine(pos.ToPosicao());

        }


    }
}
