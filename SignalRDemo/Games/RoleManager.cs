using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDemo.Games
{
    public class RoleManager
    {
        private ICollection<Role> Roles = new List<Role>();

        public void LoadRole(Role role)
        {
            if(role != null)
            {
                Roles.Add(role);
            }
        }

        public Role GetRole(string roleName = null)
        {
            Role role = string.IsNullOrEmpty(roleName) ? PickRole() : PickRole(roleName);
            if(role != null) { role.Assigned(); }
            return role;
        }

        protected Role PickRole(string roleName)
        {
            Role role = Roles
                .FirstOrDefault(x => x.GetType().Name == roleName);
            return role;
        }

        protected Role PickRole()
        {
            Role role = Roles
                .OrderBy(x => Guid.NewGuid())
                .FirstOrDefault(y => y.AvaliableCount > 0);
            return role;
        }
    }
}