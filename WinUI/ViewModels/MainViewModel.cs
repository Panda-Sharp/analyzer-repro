using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace WinUI.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private int a = 0;

        public MainViewModel()
        {
            GetDelayCommand = new AsyncRelayCommand(GetDelay);
        }

        public IAsyncRelayCommand GetDelayCommand { get; }

        public async Task GetDelay()
        {
            await Task.CompletedTask;
        }
    }
}