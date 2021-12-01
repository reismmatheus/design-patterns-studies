using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.MultiThread
{
    public class Singleton
    {
        private static Singleton _instance;
        private static int _instanceNumber = 0;
        private static object lockObject = new object();

        private Singleton()
        {
            _instanceNumber++;
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    lock (lockObject)
                    {
                        if (_instance == null)
                            _instance = new Singleton();
                    }
                Console.WriteLine($"Instance: {_instanceNumber}");
                return _instance;
            }
        }
    }
}
