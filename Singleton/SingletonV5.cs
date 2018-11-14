using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Singleton
{
    public class SingletonV5
    {
        private static readonly Lazy<SingletonV5> lazy = new Lazy<SingletonV5>(() => new SingletonV5(), LazyThreadSafetyMode.ExecutionAndPublication);

        public static SingletonV5 Instance => lazy.Value;

        static SingletonV5()
        {

        }

        private SingletonV5()
        {
            Console.WriteLine("Created!");
        }
    }
}
