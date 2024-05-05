using CalcDate.Model.Base;
using CalcDate.View;

namespace CalcDate.Controller
{
    public class PeriodController
    {
        /// <summary>Обрабатываемый период времени</summary>
        private Period _CurrentPeriod = new Period();

        private PeriodView _PeriodView = new PeriodView();

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

        /// <summary>Вывести на экран период времени</summary>
        public void ShowCurrentPeriod()
        {
            _PeriodView.Message.Insert(0, CurrentPeriod);
            _PeriodView.ShowMessage();
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
