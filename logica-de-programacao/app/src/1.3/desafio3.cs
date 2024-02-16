namespace Desafio3
{
    public class PrimeNumbers
    {
        public static int CountPrimeNumbersTo(int range)
        {  
            List<int> allnumbers = new List<int>();
            for(int i=2;i<=range;i++){
                allnumbers.Add(i);
            }

            for(int i=0; i<=range;i++){
                for(int j=2; j<range ;j++){
                    if(i<allnumbers.Count() && allnumbers[i]*j<=range){
                        allnumbers.Remove(allnumbers[i]*j);
                    }
                    else if(i==allnumbers.Count() && allnumbers[i-1]*j<=range){
                        allnumbers.Remove(allnumbers[i-1]*j);
                    }
                }
            }
            
            return allnumbers.Count();
        } 
    }
}