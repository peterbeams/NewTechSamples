using System;
using System.Diagnostics;
using Castle.Core.Interceptor;
using log4net;

namespace ILoveAOP
{
    public class StopwatchInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            invocation.Proceed();

            stopWatch.Stop();
            var logger = LogManager.GetLogger(invocation.TargetType);
            logger.Debug(string.Format("Call to '{0}.{1}' took {2}ms", invocation.TargetType.Name, invocation.MethodInvocationTarget.Name, stopWatch.ElapsedMilliseconds));
        }
    }
}