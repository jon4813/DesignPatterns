using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    //потокобезопасность. Двойная проверка (double check)
    public sealed class SingletonV3
    {
        private static SingletonV3 _instance;
        private static int _numberOfInstances;
        private static readonly object LockObject = new object();

        private SingletonV3()
        {
            Console.WriteLine("Create singleton");
            _numberOfInstances++;
            Console.WriteLine($"Instances:{_numberOfInstances}");
        }

        public static SingletonV3 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (LockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonV3();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
