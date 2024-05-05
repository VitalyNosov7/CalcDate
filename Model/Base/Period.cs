namespace CalcDate.Model.Base
{
    /// <summary>Период времени</summary>
    public class Period
    {
        /// <summary>Начало периода времени</summary>
        private DateTime _StartOfPeriod = DateTime.MinValue;
        /// <summary>Конец периода времени</summary>
        private DateTime _EndOfPeriod = DateTime.MaxValue;

        /// <summary>Начало периода времени</summary>
        public DateTime StartOfPeriod
        {
            get { return _StartOfPeriod; }
            set { _StartOfPeriod = value; }
        }

        /// <summary>Конец периода времени</summary>
        public DateTime EndOfPeriod
        {
            get { return _EndOfPeriod; }
            set { _EndOfPeriod = value; }
        }

        /// <summary>Новый период времени (без параметров)</summary>
        public Period() { }

        /// <summary>Новый период времени (с параметрами)</summary>
        /// <param name="startOfPeriod">Начало периода времени</param>
        /// <param name="endOfPeriod">Конец периода времени</param>
        public Period(DateTime startOfPeriod, DateTime endOfPeriod)
        {
            StartOfPeriod = startOfPeriod;
            EndOfPeriod = endOfPeriod;
        }

        /// <summary>Вывод строкового значения периодов времени</summary>
        public override string ToString()
        {
            return $"(Экземпляр класса Period:\nНачало периода: {StartOfPeriod}.\nКонец периода: {EndOfPeriod}.";
        }
    }
}
