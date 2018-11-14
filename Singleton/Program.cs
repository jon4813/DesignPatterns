using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSingletonV5();

            Console.ReadLine();
        }

        static void TestSingletonV1()
        {
            Console.WriteLine(SingletonV1.SomeStaticValue);
        }

        static void TestSingletonV2()
        {
            Task[] tasks = new Task[10];
            for (int i = 0; i < 10; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    var v = SingletonV2.Instance;
                });
            }

            Task.WhenAll(tasks);
        }

        static void TestSingletonV3()
        {
            Task[] tasks = new Task[10];
            for (int i = 0; i < 10; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    var v = SingletonV3.Instance;
                });
            }

            Task.WhenAll(tasks);
        }

        static void TestSingletonV4()
        {
            var v = SingletonV4.Instance;
        }

        static void TestSingletonV5()
        {
            Task[] tasks = new Task[10];
            for (int i = 0; i < 10; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    var v = SingletonV5.Instance;
                });
            }

            Task.WhenAll(tasks);
        }
    }
}
