
namespace Desafio1
{
    public class Fatorial{
        static public int Factorial(int num)
        {   
            int result = num;
            for(int i=1;i<num;i++){  
                result *= (num-i);
            }
            return result;
        }
    }
}