using Microsoft.Maui.Controls;
using OodMaui.Views;

namespace OodMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
