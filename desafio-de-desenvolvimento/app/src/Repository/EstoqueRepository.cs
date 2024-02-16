using Bebida;

namespace Estoque
{
    public static class EstoqueRepository
    {
        private static List<BebidaRepository> estoque = new List<BebidaRepository>();

        public static void AdicionaBebida(BebidaRepository bebida){
            estoque.Add(bebida);
        }   

        public static BebidaRepository EscolheBebida(int id){
            
            foreach (BebidaRepository bebida in estoque)
            {
                if(bebida.GetId()==id){
                    return bebida;
                }
            }
            Console.WriteLine("\nBebida não encontrada\n");
            return null;
        }

        public static List<BebidaRepository> GetEstoque(){
            return estoque;
        }

        public static void RemoveBebida(BebidaRepository bebida) {
            estoque.Remove(bebida);
        }
    }
}