﻿
namespace tabuleiro
{
    class Posicao
    {

        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao() { }
        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            Coluna = coluna;
            Linha = linha;

        }

        public override string ToString()
        {
            return Linha + ", " + Coluna;
        }
    }
}
