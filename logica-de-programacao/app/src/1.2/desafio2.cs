
namespace Desafio2
{
    public class RewardCalculator
    {
        public static double Reward(double basis, String type, Nullable<double> multiplier)
        {
            double result;
            if (type.Equals("basic"))
                result = basis * 1.0 * (multiplier??1.0) ;

            else if (type.Equals("vip"))
                result = basis * 1.2 * (multiplier??1.0);

            else if (type.Equals("premium"))
                result = basis * 1.5 * (multiplier??1.0);

            else if (type.Equals("deluxe"))
                result = basis * 1.8 * (multiplier??1.0);

            else
                result = basis * 2 * (multiplier??1.0);

            return result;
        }
    }
}