using Com.Pinz.Client.RemoteServiceConsumer.Callback;
using Com.Pinz.Client.RemoteServiceConsumer.ServiceImpl;
using Common.Logging;
using Ninject;
using Ninject.Extensions.Interception;
using System;
using System.Linq;

namespace Com.Pinz.Client.RemoteServiceConsumer.Infrastructure
{
    public class ChannelFactoryInterceptor : IInterceptor
    {
        private static readonly ILog Log = LogManager.GetLogger<ChannelFactoryInterceptor>();

        private IServiceRunningIndicator indicator;
        private System.Object lockThis = new System.Object();

        [Inject]
        public ChannelFactoryInterceptor(IServiceRunningIndicator indicator)
        {
            this.indicator = indicator;
        }

        public void Intercept(IInvocation invocation)
        {
            lock (lockThis)
            {
                LogBefore(invocation);
                indicator.IsServiceRunning = true;
                ServiceBase serviceBase = invocation.Request.Target as ServiceBase;
                serviceBase.OpenChannel();

                try
                {
                    invocation.Proceed();
                    LogAfter(invocation);
                }
                catch (Exception ex)
                {
                    Log.Fatal("Falied to execute call ! ", ex);
                    throw ex;
                }
                finally
                {
                    serviceBase.CloseChannel();
                    indicator.IsServiceRunning = false;
                }
            }
        }

        private void LogAfter(IInvocation invocation)
        {
            var methodName = invocation.Request.Method.Name;
            if (invocation.Request.Method.ReturnType != typeof(void))
            {
                Log.DebugFormat("Method {0} returned <{1}>", methodName, invocation.ReturnValue);
            }
        }

        private void LogBefore(IInvocation invocation)
        {
            var methodName = invocation.Request.Method.Name;

            var parameterNames = invocation.Request.Method.GetParameters().Select(p => p.Name).ToList();
            var parameterValues = invocation.Request.Arguments;

            var message = string.Format("Method {0} called with parameters ", methodName);
            for (int index = 0; index < parameterNames.Count; index++)
            {
                var name = parameterNames[index];
                var value = parameterValues[index];
                message += string.Format("<{0}>:<{1}>,", name, value);
            }

            //log method called
            Log.Debug(message);
        }
    }
}
