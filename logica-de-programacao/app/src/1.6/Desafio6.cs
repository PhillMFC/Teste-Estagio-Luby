namespace Desafio6
{
    public class Dates
    {
        public static int PeriodBetween(String firstDate, String secondDate){

            int[] firstDateTime = {double.Parse(firstDate.Substring(4)), double.Parse(firstDate.Substring(2,2)), double.Parse(firstDate.Substring(0,2)) };
            int[] secondDateTime = {double.Parse(secondDate.Substring(4)), double.Parse(secondDate.Substring(2,2)), double.Parse(secondDate.Substring(0,2)) };
            int[] period = {secondDateTime[0]-firstDateTime[0], secondDateTime[1]-firstDateTime[1], secondDateTime[2]-firstDateTime[2]};
            return period[0]*365 + period[1]*30 + period[2];
        }
    }
}