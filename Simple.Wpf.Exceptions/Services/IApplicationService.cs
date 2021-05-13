namespace Simple.Wpf.Exceptions.Services
{
    public interface IApplicationService : IService
    {
        string LogFolder { get; }

        void CopyToClipboard(string text);
        void Exit();
        void Restart();
        void OpenFolder(string folder);
    }
}