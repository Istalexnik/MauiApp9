﻿using MauiApp9.Pages;

namespace MauiApp9;
class AppShell : Shell
{
    // Dictionary to map page types to their routes
    private static readonly Dictionary<Type, string> RouteMap = new()
        {
            { typeof(MainPage), "main" }
            // Future pages can be added here, e.g., { typeof(DetailsPage), "details" }
        };

    public AppShell(MainPage mainPage)
    {
        this.FlyoutBackgroundColor = Color.FromRgb(100, 100, 100);
        //this.FlyoutBackgroundColor =  Application.Current?.RequestedTheme == AppTheme.Dark ? Color.FromRgb(300, 100, 100) : Color.FromRgb(100, 100, 300);

        // Add MainPage as a top-level item in Shell
        Items.Add(new FlyoutItem
        {
            Title = "Home",
            Icon = "dotnet_bot.png",
            Items = { new ShellContent { Content = mainPage } }
        });

        // Register each route for current and future pages
        foreach (var route in RouteMap)
        {
            Routing.RegisterRoute(route.Value, route.Key);
        }
    }

    // GetRoute method to retrieve the route string for a given page type
    public static string? GetRoute(Type type)
    {
        return RouteMap.TryGetValue(type, out var route) ? route : null;
    }

}
