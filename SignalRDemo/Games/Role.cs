using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDemo.Games
{
    public abstract class Role
    {
        public Role(uint count)
        {
            TotalCount = count;
        }
        public string Name { get { return this.GetType().Name; } }
        public uint TotalCount {get; private set;}
        public uint UsedCount { get; private set; }
        public uint AvaliableCount { get { return TotalCount - UsedCount; } }

        public void Assigned() { UsedCount++; }
    }
}