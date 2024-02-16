using Bebida;

namespace Vendas
{
    public static class VendasRepository{
        private static List<BebidaRepository> vendas = new List<BebidaRepository>();   

        public static void RegistraVenda(BebidaRepository bebida){
            if(vendas.Contains(bebida)){
                vendas.ForEach( item => {
                    if(item == bebida)
                    item.SetQuantidade(item.GetQuantidade()+1);
                });
            } else {
                vendas.Add(new BebidaRepository(bebida.GetNome(),bebida.GetValor(),bebida.GetQuantidade()));
            }
        }

        public static double Total(){
            double soma=0;
            foreach (BebidaRepository item in vendas)
            {
                soma+=(item.GetValor()*item.GetQuantidade());
            }
            return soma;
        }
    }
}