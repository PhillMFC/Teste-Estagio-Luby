namespace Desafio10
{
    public class Compare
    {
        public static int[] ObterElementosFaltantes(int[] firstVector, int[] secondVector){

            List<int> result = firstVector.Concat(secondVector).ToList<int>();

            if(firstVector.Length >= secondVector.Length){

                for(int i=0; i<firstVector.Length; i++){
                    for(int j=0; j<secondVector.Length; j++){
                        if(firstVector.Contains(secondVector[j])){
                            result.Remove(secondVector[j]);
                        }
                    }
                }
            } else {
                for(int i=0; i<secondVector.Length; i++){
                    for(int j=0; j<firstVector.Length; j++){
                        if(firstVector.Contains(firstVector[j])){
                            result.Remove(firstVector[j]);
                        }
                    }
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
                {
                    
                }
            }
            return result.ToArray();
        }
    }
}