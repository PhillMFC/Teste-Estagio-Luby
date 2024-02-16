using System.Data;

namespace Desafio9
{
    public class Matrix
    {
        public static int[,] TransformarEmMatriz(String elements){

            String[] treatedElements = elements.Split(",");
            double size = treatedElements.Length/2;
            int resultLines;

            if(size%2==0){
                resultLines = (int)Math.Round(size, MidpointRounding.AwayFromZero);
            } else {
                resultLines = (int)Math.Round(size, MidpointRounding.AwayFromZero) +1;
            }
            
            int[,] result = new int[ resultLines, 2 ];

            for(int l=0; l<treatedElements.Length; ){
                for(int i=0; i<resultLines;i++ ){
                    for(int j=0; j<2;j++ ){
                        if(l==treatedElements.Length){
                        break;
                        }

                        result[i,j]  = Int32.Parse(treatedElements[l]);
                        l++;
                    }
                }  
            }


            for(int l=0; l<resultLines; l++){
                for(int j=0; j<2; j++){
                    Console.WriteLine($"[{result[l,j]}]");
                }
            }

            return result;
        }
    }
}