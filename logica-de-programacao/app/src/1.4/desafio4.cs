using System.Data;

namespace Desafio4
{
    public class VogalCounter{
        public static int Counter(String phrase){
            int vogals = 0;
            for(int i=0; i<phrase.Length;i++){
                if(phrase[i]==97 || phrase[i]==101 || phrase[i]==105 || phrase[i]==111 || phrase[i]==117 ||  phrase[i]==65 || phrase[i]==69 || phrase[i]==73 || phrase[i]==79 || phrase[i]==85)
                    vogals++;
            }
            return vogals;
        } 
    }
}