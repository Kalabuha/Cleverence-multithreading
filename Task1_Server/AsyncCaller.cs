namespace Task1_Server
{
    public class AsyncCaller
    {
        private readonly EventHandler _handler;

        public AsyncCaller(EventHandler handler)
        {
            _handler = handler;
        }

        public bool Invoke(int millisecondsDelay, object? sender, EventArgs args)
        {
            var task = Task.Run(() => _handler(sender, args));
            Task.WaitAny(task, Task.Delay(millisecondsDelay));
            return task.IsCompletedSuccessfully;
        }
    }
}
