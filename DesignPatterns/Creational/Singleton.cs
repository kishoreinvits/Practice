using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{    
    // Hard to test singleton because instances are carried between tests. Better yet, use DI
    internal class SingletonEagerInitialized
    {
        // Static members are initialized eagerly when class is loaded
        // dotnet guarantees thread safety for static initialization
        private static readonly SingletonEagerInitialized instance = new SingletonEagerInitialized();

        // private constructor
        private SingletonEagerInitialized()
        {
        }

        public static SingletonEagerInitialized Instance()
        {
            return instance;
        }

    }
    internal class SingletonLazyInitialized
    {
        private static SingletonLazyInitialized? _instance;
        private static readonly object _lock = new object();

        // private constructor
        private SingletonLazyInitialized()
        {
        }

        public static SingletonLazyInitialized Instance()
        {
            // double check lock
            if (_instance == null)
            {
                lock (_lock) {
                    if (_instance == null)
                    {
                        _instance = new SingletonLazyInitialized();
                    }
                }
            }
            return _instance;
        }
    }
}
