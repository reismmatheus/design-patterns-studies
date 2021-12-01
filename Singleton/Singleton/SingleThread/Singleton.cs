using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.SingleThread
{
    public class Singleton
    {
        private static Singleton _instance;
        private int _instanceNumber = 0;

        private Singleton()
        {
            _instanceNumber++;
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null) 
                    _instance = new Singleton();
                return _instance;
            }
        }
    }
}
