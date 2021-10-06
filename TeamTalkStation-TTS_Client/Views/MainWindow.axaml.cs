using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TeamTalkStation_TTS_Client.Controls;

namespace TeamTalkStation_TTS_Client.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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