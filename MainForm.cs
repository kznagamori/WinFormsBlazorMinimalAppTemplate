using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace ___PROJECTNAME___;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        var services = new ServiceCollection();
        services.AddWindowsFormsBlazorWebView();
        var serviceProvider = services.BuildServiceProvider();
        var blazorWebView = new BlazorWebView
        {
            Dock = DockStyle.Fill,
            HostPage = "wwwroot\\index.html",
            Services = serviceProvider,
        };
        blazorWebView.RootComponents.Add<Components.Pages.Main>("#app");
        Controls.Add(blazorWebView);
    }
}
