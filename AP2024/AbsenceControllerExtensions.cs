using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2024
{
    public static class AbsenceControllerExtensions
    {
        public static Task InvokeAsync(this Control control, Action action)
        {
            var tcs = new TaskCompletionSource<object>();
            control.BeginInvoke(new MethodInvoker(() =>
            {
                try
                {
                    action();
                    tcs.SetResult(null);
                }
                catch (Exception ex)
                {
                    tcs.SetException(ex);
                }
            }));
            return tcs.Task;
        }
    }
}
