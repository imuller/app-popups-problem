using CommunityToolkit.Maui.Views;
using Mopups.Services;

namespace AppPopupsProblem;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnOpenMopupsPage(object sender, EventArgs e)
    {
        var popup = new MopupsPage();

        await MopupService.Instance.PushAsync(popup);
    }
    
    private async void OnOpenToolkitPopupPage(object sender, EventArgs e)
    {
        var popup = new ToolkitPopupPage();

        await this.ShowPopupAsync(popup);
    }
}