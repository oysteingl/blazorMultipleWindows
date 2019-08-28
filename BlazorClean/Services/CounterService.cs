using System;

namespace BlazorClean.Services
{
    public class CounterService
    {
        public event EventHandler<int> CounterIncremented;
        public int CurrentCount { get; set; }

        public int IncreaseCount()
        {
            CurrentCount += 1;
            CounterIncremented?.Invoke(this, CurrentCount);
            return CurrentCount;
            
        }
    }
}