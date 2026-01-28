using System.Threading.Tasks;

namespace CP.Shared.Primitives.Avails.Extensions
{
    public static class TaskExtensions
    {
        public static void FireAndForget(this Task task)
        {
            task.ContinueWith(aTask =>
                              {
                                  System.Diagnostics.Debug.WriteLine(aTask.Exception);
                              }
                            , TaskContinuationOptions.OnlyOnFaulted);
        }
    }
}