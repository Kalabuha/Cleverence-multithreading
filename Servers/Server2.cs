namespace Servers
{
    public static class Server2
    {
        private static long _count;
        private static ReaderWriterLockSlim _lock;
        static Server2()
        {
            _lock = new ReaderWriterLockSlim();
            _count = 0;
        }

        public static long GetCount()
        {
            _lock.EnterReadLock();
            try
            {
                return _count;
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }

        public static void AddToCount(long value)
        {
            _lock.EnterWriteLock();
            try
            {
                ++_count;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
    }
}
