using CalcDate.Controller;

namespace CalcDate
{
    public class Program
    {
        public static String InputDate = String.Empty;
        public static DateTime UserDate = new DateTime();
        // public static DateTime CheckInDate = new DateTime();
        // public static DateTime DepartureDate = new DateTime();

        public static void Main()
        {

            PeriodController  PeriodContr = new PeriodController();
            PeriodContr.ShowCurrentPeriod();

            // Это рабочий код. Не удалять!
            //DateTime CheckInDate = new DateTime();
            //DateTime DepartureDate = new DateTime();
            //DateTime CurrentDate = new DateTime();

            //TimeSpan Interval;


            //ConsoleKeyInfo btn;
            //do
            //{
            //    Console.WriteLine("Версия: 0.0.1 ");

            //    CurrentDate = DateTime.Now;

            //    //Console.Write("Введите дату заезда: ");
            //    CheckInDate = GetInputDate("Введите дату заезда: ");

            //    //Console.Write("Введите дату выезда: ");
            //    DepartureDate = GetInputDate("Введите дату выезда: ");

            //    Interval = DepartureDate - CheckInDate;

            //    Console.ForegroundColor = ConsoleColor.Green;

            //    Console.WriteLine($"Колво дней: {(Interval).Days}");

            //    Console.ResetColor();

            //    Interval = CheckInDate.AddDays(1) - CurrentDate;

            //    if (Interval.Days <= 14)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //    }

            //    Console.WriteLine($"До заезда остаётся(дня(ей)): {(Interval).Days}");

            //    Console.ResetColor();

            //    Console.WriteLine("Для продолжения нажмите любую клавишу. Для выхода нажмите [ESC]");



            //    btn = Console.ReadKey();
            //}
            //while (!(btn.Key == ConsoleKey.Escape));
        }

        public static DateTime GetInputDate(String message)
        {
            Boolean DateVerification = false;
            do
            {
                Console.Write(message);
                try
                {
                    InputDate = Console.ReadLine();
                    UserDate = Convert.ToDateTime(InputDate);
                    DateVerification = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введена неверная дата!");
                    Console.ResetColor();
                    DateVerification = false;
                }
            }
            while (DateVerification == false);

            return UserDate;

        }
    }
}
