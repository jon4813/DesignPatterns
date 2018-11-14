using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    //если вызвать только SomeStaticValue, но не вызывать Instance,
    //то Instance всё равно инициализируется.
    public sealed class SingletonV1
    {
        private static readonly SingletonV1 _instance = new SingletonV1();
        private static int _numberOfInstances = 0;

        private SingletonV1()
        {
            Console.WriteLine("Create singleton");
            _numberOfInstances++;
            Console.WriteLine($"Instances:{_numberOfInstances}");
        }

        public static SingletonV1 Instance => _instance;

        public static int SomeStaticValue = 358;

    }
}
