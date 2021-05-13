using System;
using System.ComponentModel;

namespace Simple.Wpf.Exceptions.ViewModels
{
    public interface IViewModel : IDisposable, INotifyPropertyChanged
    {
        IDisposable SuspendNotifications();
    }
}