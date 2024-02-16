using Bebida;
using Estoque;
using Home;

namespace Main{

    public class Program
    {
        static void Main(string[] args)
        {

            EstoqueRepository.AdicionaBebida(new BebidaRepository("Coca-cola", 5, 1));
            EstoqueRepository.AdicionaBebida(new BebidaRepository("Guaraná", 6, 2));
            EstoqueRepository.AdicionaBebida(new BebidaRepository("Schweppes", 7, 10));

            HomeViewController.Home();

        }
    }
}