using System;
using Avalonia;

namespace SpiderDesk
{
    internal static class Program
    {
        [STAThread]
        public static void Main(string[] Arguments)
        {
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(Arguments);
        }

        public static AppBuilder BuildAvaloniaApp()
        {
            return AppBuilder.Configure<App>()
                      .UsePlatformDetect()
                      #if DEBUG
                      .WithDeveloperTools()
                      #endif
                      .WithInterFont()
                      .LogToTrace();
        }
    }
}