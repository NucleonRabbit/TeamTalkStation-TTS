using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;
using SkiaSharp;
using System.IO;
using TeamTalkStation_TTS_Client.Services;
using TeamTalkStation_TTS_Client.ViewModels;
using TeamTalkStation_TTS_Client.Views;

namespace TeamTalkStation_TTS_Client
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };

                // desktop.MainWindow = new ProfileEditWindow();

                // desktop.MainWindow = new LoginWindow();
            }

            base.OnFrameworkInitializationCompleted();
        }


        /// <summary>
        /// override RegisterServices to register custom service
        /// </summary>
        public override void RegisterServices()
        {
            AvaloniaLocator.CurrentMutable.Bind<IFontManagerImpl>().ToConstant(new CustomFontManagerImpl());
            base.RegisterServices();
        }
    }
}