using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Thread");
            var s1 = SingleThread.Singleton.Instance;
            var s2 = SingleThread.Singleton.Instance;

            if (s1 == s2)
                Console.WriteLine("Single Thread => s1 == s2");

            Console.WriteLine("Multi Thread");

            Parallel.Invoke(
                () => ThreadAccess(1),
                () => ThreadAccess(2)
            );

            Console.ReadLine();
        }

        private static void ThreadAccess(int thread)
        {
            var s1 = MultiThread.Singleton.Instance;
            Console.WriteLine($"Thread {thread}");
        }
    }
}
