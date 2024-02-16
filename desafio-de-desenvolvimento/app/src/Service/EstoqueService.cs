using Bebida;
using Estoque;

namespace Estoqueservice
{
    public static class EstoqueService
    {
        public static void AtualizaEstoque(BebidaRepository bebidaComprada){
            List<BebidaRepository> bebidasRemovidas = new List<BebidaRepository>();
            EstoqueRepository.GetEstoque().ForEach( bebida => {
                if(bebida.GetQuantidade()>0 && bebida == bebidaComprada){
                    bebida.CompraUnidade();
                }
                if(bebida.GetQuantidade()==0){
                    bebidasRemovidas.Add(bebida);                    
                }
            }); 

            foreach (BebidaRepository item in bebidasRemovidas)
            {
                EstoqueRepository.RemoveBebida(item);
                
            }
        }

        public static void RegistraVenda(){

        }
    }
}