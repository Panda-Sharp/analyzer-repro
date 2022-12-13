using Microsoft.Extensions.DependencyInjection;
using Windows.UI.Xaml.Controls;
using WinUI.ViewModels;

namespace WinUI.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            DataContext = App.Current.Services.GetService<MainViewModel>();
        }

        private MainViewModel ViewModel => (MainViewModel)DataContext;
    }
}