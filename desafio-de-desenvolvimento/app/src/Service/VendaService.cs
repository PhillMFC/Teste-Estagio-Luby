using Bebida;
using Estoque;
using Estoqueservice;
using Home;

namespace Venda
{
    public static class VendaService
    {
        public static void ConcluirVenda(BebidaRepository bebida, double valorPago){

            if(valorPago<bebida.GetValor()){
               
                while(bebida.GetValor() - valorPago > 0){
                    Console.WriteLine($"\nPagamento insuficiente.\nValor restante para concluir o pagamento: R${(bebida.GetValor() - valorPago).ToString("0.00")}\nInsira o valor restante:\n");
                    double novoValor = double.Parse(Console.ReadLine());
                    ConcluirVenda(bebida, valorPago+novoValor); 
                    return;
                }
            } else {
                    Console.WriteLine($"\nTroco:R${(valorPago - bebida.GetValor()).ToString("0.00")}");
                    EstoqueService.AtualizaEstoque(bebida);
                    HomeViewController.Home();

            }
        }
    }
}