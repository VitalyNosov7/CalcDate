using CalcDate.Controller;

namespace CalcDate
{
    public class Program
    {
        public static void Main()
        {
            PeriodController periodController = new PeriodController();
            periodController.EnterUserDate();
        }
    }
}
