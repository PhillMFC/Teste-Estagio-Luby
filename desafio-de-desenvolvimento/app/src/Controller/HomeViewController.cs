using Estoque;
using Bebida;
using Venda;
using Vendas;

namespace Home
{
    public static class HomeViewController
    {   
        public static void Home(){
            Console.WriteLine("\nBebidas disponíveis:\n");
            EstoqueRepository.GetEstoque().ForEach( bebida => Console.WriteLine($"Opção {bebida.GetId()}: {bebida.GetNome()} - R$ {bebida.GetValor().ToString("0.00")}"));
            Console.WriteLine("Opção 4: Visualizar estoque.");
            Console.WriteLine("Opção 5: Visualizar total de vendas.\n");

            Console.WriteLine("\nDigite o número da opção desejada: ");
            int id = Int32.Parse(Console.ReadLine());

            if(id==4){
                Console.WriteLine("\nEstoque:\n");
                EstoqueRepository.GetEstoque().ForEach( bebida => Console.WriteLine($"{bebida.GetNome()} - Quantidade: {bebida.GetQuantidade()}"));
            } 
            else if(id==5){
                Console.WriteLine($"R$ {VendasRepository.Total().ToString("0.00")}");
                
            }
            else {
                HomeViewController.Venda(EstoqueRepository.EscolheBebida(id));
            }
            HomeViewController.Home();


        }

        public static void Venda(BebidaRepository bebida){

            if(bebida is not null){
                Console.WriteLine($"\nProduto selecionado: {bebida.GetNome() }\nValor :  R$ {bebida.GetValor().ToString("0.00")}");
            } else {
                int id = Int32.Parse(Console.ReadLine());
                HomeViewController.Venda(EstoqueRepository.EscolheBebida(id));
                return;
            }

            Console.WriteLine("\nInsira o valor do pagamento:\n");
            double valor = double.Parse(Console.ReadLine());
            VendaService.ConcluirVenda(bebida, valor);

        }
    }
}