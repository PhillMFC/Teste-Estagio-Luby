namespace Desafio7
{
    public class Even
    {
        public static int[] ReturnEvenFrom(int[] vector)
        {
            List<int> temp = new List<int>();
            for(int i=0; i<vector.Length; i++){
                if(vector[i]%2==0){
                    temp.Add(vector[i]);
                }
            }
            return temp.ToArray();
        }
    }
}