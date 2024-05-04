namespace CalcDate
{
    public class Program
    {
        public static String InputDate = String.Empty;
        // public static DateTime CheckInDate = new DateTime();
        // public static DateTime DepartureDate = new DateTime();

        public static void Main()
        {
            DateTime CheckInDate = new DateTime();
            DateTime DepartureDate = new DateTime();
            DateTime CurrentDate = new DateTime();
            TimeSpan Interval;


            ConsoleKeyInfo btn;
            do
            {
                Console.WriteLine("Версия: 0.0.1 ");

                CurrentDate = DateTime.Now;

                Console.Write("Введите дату заезда: ");
                CheckInDate = GetInputDate();

                Console.Write("Введите дату выезда: ");
                DepartureDate = GetInputDate();

                Interval = DepartureDate - CheckInDate;

                Console.WriteLine($"Колво дней: {(Interval).Days}");

                Interval = CheckInDate.AddDays(1) - CurrentDate;

                Console.WriteLine($"До заезда остаётся(дня(ей)): {(Interval).Days}");

                Console.WriteLine("Для продолжения нажмите любую клавишу. Для выхода нажмите [ESC]");

                btn = Console.ReadKey();
            }
            while (!(btn.Key == ConsoleKey.Escape));
        }

        public static DateTime GetInputDate()
        {
            InputDate = Console.ReadLine();
            return Convert.ToDateTime(InputDate);
        }
    }
}
