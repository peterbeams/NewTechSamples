using System;
using Castle.Core.Interceptor;
using Castle.DynamicProxy;

namespace ILoveAOP
{
    public class InterceptorFactory<T>
    {
        public static T Create(T instance)
        {
            var stopwatchInterceptor = new StopwatchInterceptor();
            var securityInterceptor = new ServiceSecurityInterceptor();
            var proxyGenerator = new ProxyGenerator();
            var proxy = proxyGenerator.CreateInterfaceProxyWithTarget(typeof(T), new Type[] { }, instance, new IInterceptor[] { stopwatchInterceptor, securityInterceptor });
            return (T)proxy;
        }
    }
}