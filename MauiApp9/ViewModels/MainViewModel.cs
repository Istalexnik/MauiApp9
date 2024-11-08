using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp9.ViewModels;
partial class MainViewModel : BaseViewModel
{
    public MainViewModel()
    {
    }

    [ObservableProperty]
    int _clickCount = 0;

    [RelayCommand]
    void IncrementClickMeButton() => ClickCount += 1;
}
