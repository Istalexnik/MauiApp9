﻿using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using MauiApp9.Helpers;
using Microsoft.Extensions.Logging;

namespace MauiApp9;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitMarkup()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<App>();
        builder.Services.AddSingleton<AppShell>();
        //builder.Services.AddTransientWithShellRoute<MainPage, MainViewModel>($"//{nameof(MainPage)}");
        builder.Services.AddSingleton<ICommunityToolkitHotReloadHandler, HotReloadHandler>();

        return builder.Build();
    }
}
