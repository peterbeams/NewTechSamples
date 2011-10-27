using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILoveAOP.Services
{
    public class SecurityContext
    {
        public static string[] Roles { get; set; }
    }

    public class RequiresRoleAttribute : Attribute
    {
        public string RoleName { get; set; }

        public RequiresRoleAttribute(string roleName)
        {
            RoleName = roleName;
        }
    }
}
