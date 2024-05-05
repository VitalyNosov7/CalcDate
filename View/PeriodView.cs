using System.Text;

namespace CalcDate.View
{
    /// <summary>Отображение информации по периоду на экране</summary>
    public class PeriodView
    {
        /// <summary>Сообщение, выводимое на экран</summary>
        private StringBuilder _Message = new StringBuilder();

        /// <summary>Сообщение, выводимое на экран</summary>
        public StringBuilder Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        /// <summary>Новый экземпляр вида отображения периода времени</summary>
        public PeriodView() { }

        /// <summary>Вывод информационного сообщения</summary>
        public void ShowMessage(ConsoleColor foregroundСolor)
        {
            Console.ForegroundColor = foregroundСolor;
            Console.Write(_Message);
            ClearMessage();
            Console.ResetColor();
        }

        /// <summary>Очистить данные (Сообщение в поле _Message)</summary>
        public void ClearMessage()
        {
            _Message.Clear();
        }

        /// <summary>Вывод строкового значения сообщения</summary>
        public override string ToString()
        {
            return $"(Экземпляр класса PeriodView:\n{_Message}";
        }
    }
}
