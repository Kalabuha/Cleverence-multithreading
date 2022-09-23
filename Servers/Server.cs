namespace Servers
{
    public static class Server
    {
        private static long _count;
        static Server()
        {
            _count = 0;
        }

        public static long GetCount()
        {
            var count = Interlocked.Read(ref _count);
            return count;
        }

        public static void AddToCount(long value)
        {
            Interlocked.Add(ref _count, value);
        }
    }
}
