using System;
using System.Linq;
using Castle.Core.Interceptor;
using ILoveAOP.Services;

namespace ILoveAOP
{
    public class ServiceSecurityInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var attr = invocation.MethodInvocationTarget.GetCustomAttributes(typeof(RequiresRoleAttribute), true).FirstOrDefault() as RequiresRoleAttribute;
            if (attr != null)
            {
                var roleName = attr.RoleName;
                if (!SecurityContext.Roles.Contains(roleName, StringComparer.InvariantCultureIgnoreCase))
                {
                    throw new UnauthorizedAccessException("User does not have required role.");
                }
            }

            invocation.Proceed();
        }
    }
}