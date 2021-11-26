using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TeamTalkStation_TTS_Client.ViewModels;
using TeamTalkStation_TTS_Client.Controls;

namespace TeamTalkStation_TTS_Client.Views
{
    public class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainWindowViewModel();
            
            
            
            

#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}