namespace Simple.Wpf.Exceptions.Extensions
{
    public static class CompositeDisposableExtensions
    {
        // had to add reference to ReactiveUI to get DispatcherScheduler static reference in SchedulerService, this means this extension method is no longer needed...

        // public static T DisposeWith<T>(this T instance, CompositeDisposable disposable) where T : IDisposable
        // {
        //     disposable.Add(instance);
        //
        //     return instance;
        //
        // }
    }
}