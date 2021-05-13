using Simple.Wpf.Exceptions.Commands;

namespace Simple.Wpf.Exceptions.ViewModels
{
    public interface IChromeViewModel : IViewModel
    {
        IMainViewModel Main { get; }
        ReactiveCommand<object> CloseOverlayCommand { get; }
        bool HasOverlay { get; }
        string OverlayHeader { get; }
        BaseViewModel Overlay { get; }
    }
}