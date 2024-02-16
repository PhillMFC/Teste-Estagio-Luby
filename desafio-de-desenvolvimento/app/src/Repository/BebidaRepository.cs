namespace Bebida
{
    public class BebidaRepository
    {
        private String nome;
        private double valor;
        private int quantidade;
        private static int baseId = 1;
        private int id;

        public BebidaRepository(String nome, double valor, int quantidade){
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
            this.id = baseId++;
        }

        public string GetNome() {return nome;}
        public double GetValor() {return valor;}
        public int GetQuantidade() {return quantidade;}
        public int GetId() {return id;}

        public void CompraUnidade() { this.quantidade-=1;}

        public void SetQuantidade(int valor) { this.quantidade-=valor;}





    }
}