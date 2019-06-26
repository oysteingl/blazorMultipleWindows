namespace BlazorClean.Services
{
    public class CounterService
    {
        public int CurrentCount { get; set; }

        public int IncreaseCount()
        {
            CurrentCount += 1;
            return CurrentCount;
        }
    }
}