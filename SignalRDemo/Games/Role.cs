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

        public Role Assigned()
        {
            if (AvaliableCount == 0)
            {
                return null;
            }
            lock (_roleLocker) { UsedCount++; }
            return this;
        }

        private object _roleLocker = new object();
    }

    public class RoleManager : Manager<Role>
    {
        public Role GetRole(string roleName = null)
        {
            Role role = null;
            role = string.IsNullOrEmpty(roleName) ? PickRole() : PickRole(roleName);

            if (role != null) { role = role.Assigned(); }
            return role;
        }

        protected Role PickRole(string roleName)
        {
            Role role = All
                .FirstOrDefault(x => x.GetType().Name == roleName);
            return role;
        }

        protected Role PickRole()
        {
            Role role = All
                .OrderBy(x => Guid.NewGuid())
                .FirstOrDefault(y => y.AvaliableCount > 0);
            return role;
        }
    }
}