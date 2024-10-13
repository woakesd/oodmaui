using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace OodMaui.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private int _count;

    public event PropertyChangedEventHandler? PropertyChanged;

    public int Count { 
        get => _count;
        
        private set => _count = value;
    }

    private string _buttonText = "Click me";
    public string ButtonText {
        get => _buttonText; 
        private set
        {
            _buttonText = value;
            OnPropertyChanged();
        }
    }

    public ICommand IncreaseCountCommand { get; }

    public MainViewModel()
    {
        IncreaseCountCommand = new RelayCommand(IncreaseCountAsync);
    }

    void IncreaseCountAsync()
    {
        Count++;
        ButtonText = Count == 1 ? $"Clicked {Count} time" : $"Clicked {Count} times";
    }

    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
