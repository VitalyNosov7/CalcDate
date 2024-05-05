using System.Text;

namespace CalcDate.View
{
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

        public void ShowMessage()
        {
            Console.WriteLine(Message);
        }

        /// <summary>Вывод строкового значения сообщения</summary>
        public override string ToString()
        {
            return $"(Экземпляр класса PeriodView:\n{Message}";
        }
    }
}
