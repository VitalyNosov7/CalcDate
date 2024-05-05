namespace CalcDate.Interfaces
{
    public interface IPeriod
    {
        void CreateNewPeriod(DateTime startOfPeriod, DateTime endOfPeriod);
        void ShowCurrentPeriod();
    }
}
