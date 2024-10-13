using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.ApplicationModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OodMaui.ViewModels;

internal class AboutViewModel
{
    public string Title = AppInfo.Name;
    public string Version = AppInfo.Version.ToString();
    public string MoreInfoUrl = "https://aka.ms/maui";
    public string Message = "This app is written in Xaml and C# with .NET MAUI.";
    public ICommand ShowMoreInfoCommand { get; }

    public AboutViewModel()
    {
        ShowMoreInfoCommand = new AsyncRelayCommand(ShowMoreInfoAsync);
    }

    async Task ShowMoreInfoAsync() =>
        await Launcher.Default.OpenAsync(MoreInfoUrl);
}