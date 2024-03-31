using System;
using System.Collections.Generic;
using System.Text;

namespace HRadministrationnAPI
{
    public static class FactoryPattern<K, T> where T: class, K, new()
    {
        public static K GetInstance()
        {
            K objK;
            objK = new T();
            return objK;
        }
    }
}
