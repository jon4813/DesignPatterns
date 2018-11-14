using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class SingletonV4
    {
        static SingletonV4()
        {
            Console.WriteLine("Singleton!");
        }

        private SingletonV4()
        {
        }

        public static SingletonV4 Instance => Nested.Instance;

        private class Nested
        {
            static Nested()
            {
                Console.WriteLine("Nested!");
            }

            internal static readonly SingletonV4 Instance = new SingletonV4();
        }

    }
}
