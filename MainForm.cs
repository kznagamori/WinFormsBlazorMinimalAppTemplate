using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using ___PROJECTNAME___.Components;

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
        blazorWebView.RootComponents.Add<Routes>("#app");
        Controls.Add(blazorWebView);
    }
}
