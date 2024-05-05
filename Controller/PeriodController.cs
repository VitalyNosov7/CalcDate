using CalcDate.Interfaces;
using CalcDate.Model.Base;
using CalcDate.View;

namespace CalcDate.Controller
{
    public class PeriodController : IPeriod
    {
        /// <summary>Обрабатываемый период времени</summary>
        private Period _CurrentPeriod = new Period();
        /// <summary>Отображение периода времени</summary>
        private PeriodView _PeriodView = new PeriodView();
        /// <summary>Введеная пользователем дата в строковом виде</summary>
        public String? InputDate = String.Empty;
        /// <summary>Полученная дата от пользователя после проверки</summary>
        public DateTime UserDate = new DateTime();

        /// <summary>Обрабатываемый период времени</summary>
        public Period CurrentPeriod
        {
            get { return _CurrentPeriod; }
            set { _CurrentPeriod = value; }
        }

        /// <summary>Новый контроллер(обработчик) периода времени (без параметров)</summary>
        public PeriodController() { }

        /// <summary>Новый контроллер(обработчик) периода времени (с параметрами)</summary>
        /// <param name="currentPeriod">Обрабатываемый период времени</param>
        public PeriodController(Period currentPeriod)
        {
            CurrentPeriod = currentPeriod;
        }

        /// <summary>Создать новый период времени (с параметрами)</summary>
        /// <param name="startOfPeriod">Начало периода времени</param>
        /// <param name="endOfPeriod">Конец периода времени</param>
        public void CreateNewPeriod(DateTime startOfPeriod, DateTime endOfPeriod)
        {
            CurrentPeriod = new Period(startOfPeriod, endOfPeriod);
        }

        //  TODO: Оптимизировать код:
        //  1. Убрать вывод инфо в отдельный метод(чтобы вызов был в одну строку кода а не в две)
        /// <summary>Ввод даты пользователем</summary>
        public void EnterUserDate()
        {
            DateTime CheckInDate = new DateTime();
            DateTime DepartureDate = new DateTime();
            DateTime CurrentDate = new DateTime();

            TimeSpan Interval;


            ConsoleKeyInfo btn;
            do
            {
                _PeriodView.Message.Insert(0, "РАСЧЕТ ПЕРИОДОВ ЗАЕЗДА В ОТЕЛЬ [Версия: 0.0.1]\n");
                _PeriodView.ShowMessage(ConsoleColor.Green);

                CurrentDate = DateTime.Now;

                CheckInDate = GetInputDate("Введите дату заезда: ");

                DepartureDate = GetInputDate("Введите дату выезда: ");

                Interval = DepartureDate - CheckInDate;

                _PeriodView.Message.Insert(0, $"Количество дней пребывания в отеле: {(Interval).Days}");
                _PeriodView.ShowMessage(ConsoleColor.Green);

                Interval = CheckInDate.AddDays(1) - CurrentDate;

                if (Interval.Days <= 14)
                {
                    _PeriodView.Message.Insert(0, $"\nДо заезда остаётся: {(Interval).Days} дня(ей)");
                    _PeriodView.ShowMessage(ConsoleColor.Red);
                }
                else
                {
                    _PeriodView.Message.Insert(0, $"\nДо заезда остаётся: {(Interval).Days} дня(ей)");
                    _PeriodView.ShowMessage(ConsoleColor.Green);
                }

                _PeriodView.Message.Insert(0, "\nДля продолжения нажмите любую клавишу. Для выхода нажмите [ESC]\n");
                _PeriodView.ShowMessage(ConsoleColor.White);

                btn = Console.ReadKey();

                Console.Clear();
            }
            while (!(btn.Key == ConsoleKey.Escape));
        }

        public DateTime GetInputDate(String message)
        {
            Boolean DateVerification = false;
            do
            {
                _PeriodView.Message.Insert(0, message);
                _PeriodView.ShowMessage(ConsoleColor.White);
                try
                {
                    InputDate = Console.ReadLine();
                    UserDate = Convert.ToDateTime(InputDate);
                    DateVerification = true;
                }
                catch
                {
                    _PeriodView.Message.Insert(0, "Введена неверная дата!\n");
                    _PeriodView.ShowMessage(ConsoleColor.Red);

                    DateVerification = false;
                }
            }
            while (DateVerification == false);

            return UserDate;
        }

        /// <summary>Вывести на экран период времени</summary>
        public void ShowCurrentPeriod()
        {
            _PeriodView.Message.Insert(0, CurrentPeriod);
            _PeriodView.ShowMessage(ConsoleColor.Gray);
        }

        /// <summary>Вывод строкового значения периодов времени</summary>
        public override string ToString()
        {
            return $"Экземпляр класса PeriodController:\n" +
                    $"Начало периода: {CurrentPeriod.StartOfPeriod}.\n" +
                    $"Конец периода: {CurrentPeriod.EndOfPeriod}";
        }
    }
}
