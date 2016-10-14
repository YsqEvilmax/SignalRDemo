using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDemo.Games
{
    public class Manager<T>
    {
        public Manager()
        {
            All = new List<T>();
        }

        public List<T> All { get; }
    }
}