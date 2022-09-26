using Microsoft.AspNetCore.Components.WebView.Maui;

namespace Maui
{
    public static class MauiProgram
    {
        private const string webApiHostAddress = "https://localhost:7169/";
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(webApiHostAddress) });

            return builder.Build();
        }
    }
}