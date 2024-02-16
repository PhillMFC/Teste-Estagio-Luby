namespace Desafio5
{
    public class Desconto
    {
        public static double AplicaDesconto(String basis, String discount){
            
            double value = Convert.ToDouble(basis.Substring(3));
            double discountValue = Convert.ToDouble(discount.Remove(discount.LastIndexOf("%")))/100.0;
            
            return value  - value*discountValue;
        }
    }
}