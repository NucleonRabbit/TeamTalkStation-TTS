using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Extensions.Controls;
using Avalonia.ReactiveUI;


namespace TeamTalkStation_TTS_Client
{
    class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        public static void Main(string[] args)
        {

            //Modules.PlatformDetect.DetectLinux();
            
            BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args)
                ;
        }

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .With(new X11PlatformOptions {EnableMultiTouch = true, UseDBusMenu = true, EnableIme = true})
                .LogToTrace()
                .UseDoveExtensions()
                .UseChineseInputSupport()
                .UseReactiveUI();
    }
}