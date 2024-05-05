using CommunityToolkit.Mvvm.ComponentModel;

namespace Thirsty.ViewModels
{
    public partial class ShellViewModel : ObservableObject
    {
        [ObservableProperty]
        public string title = "Thirsty";
    }
}
