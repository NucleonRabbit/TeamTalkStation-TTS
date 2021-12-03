using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;
using TeamTalkStation_TTS_Client.Views;
using ReactiveUI;
using Splat;
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
            //var suspension = new AutoSuspendHelper(ApplicationLifetime);
            //RxApp.SuspensionHost.CreateNewAppState = () => new MainWindowViewModel();
            //RxApp.SuspensionHost.SetupDefaultSuspendResume(new NewtonsoftJsonSuspensionDriver("appstate.json"));
           // suspension.OnFrameworkInitializationCompleted();


            //Locator.CurrentMutable.RegisterConstant<IScreen>(RxApp.SuspensionHost.GetAppState<MainWindowViewModel>());
            // Locator.CurrentMutable.Register<IViewFor<ChatViewModel>>(() => new ChatView());
            
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow()
                {
                    DataContext = new MainWindowViewModel(),
                };

                desktop.MainWindow = new MainWindow();
                //desktop.MainWindow = new ProfileEditWindow();
            }
            
            //Avalonia.Input.TextInput.
            
            base.OnFrameworkInitializationCompleted();
        }
        
        
        /// <summary>
        /// override RegisterServices register custom service
        /// </summary>
        public override void RegisterServices()
        {
            AvaloniaLocator.CurrentMutable.Bind<IFontManagerImpl>().ToConstant(new CustomFontManagerImpl());
            base.RegisterServices();
        }
    }
}