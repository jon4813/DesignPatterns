using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    //Нет защиты от многопоточности. Возможно создание множества экземпляров
    public sealed class SingletonV2
    {
        private static SingletonV2 _instance;
        private static int _numberOfInstances = 0;

        private SingletonV2()
        {
            Console.WriteLine("Create singleton");
            _numberOfInstances++;
            Console.WriteLine($"Instances:{_numberOfInstances}");
        }

        public static SingletonV2 Instance => _instance ?? (_instance = new SingletonV2());
    }
}
