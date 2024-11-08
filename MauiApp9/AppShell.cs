using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp9;
public partial class AppShell : Shell
{
    // Dictionary to map page types to their routes
    private static readonly Dictionary<Type, string> RouteMap = new()
        {
            { typeof(MainPage), "main" }
            // Future pages can be added here, e.g., { typeof(DetailsPage), "details" }
        };

    public AppShell(MainPage mainPage)
    {
        // Add MainPage as a top-level item in Shell
        Items.Add(new FlyoutItem
        {
            Title = "Home",
            Icon = "home_icon.png",
            Items = { new ShellContent { Content = mainPage } }
        });

        // Register routes for current and future pages
        RegisterRoutes();
    }

    // Register each route in the RouteMap dictionary with Shell
    private void RegisterRoutes()
    {
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
