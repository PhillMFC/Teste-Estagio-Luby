namespace Desafio8
{
    public class Search
    {
        public static String[] BuscaPessoa(String[] vetor, String element)
        {
            List<String> result = new List<String>();
            for(int i=0; i<vetor.Length;i++){
                if(vetor[i].Contains(element)){
                    result.Add(vetor[i]);
                }
            }
            return result.ToArray(); 
        }
    }
}